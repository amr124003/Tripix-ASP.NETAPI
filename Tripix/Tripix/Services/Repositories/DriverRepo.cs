using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Driver;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Hubs;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class DriverRepo : IDriverRepo
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly IJwtProvider jwtProvider;
        private readonly IHubContext<UserHub> hubcontext;
        private readonly IDistributedCache cache;

        public DriverRepo ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger, IJwtProvider jwtProvider, IHubContext<UserHub> hubcontext, IDistributedCache cache )
        {
            this.context = context;
            this.usermanger = usermanger;
            this.jwtProvider = jwtProvider;
            this.hubcontext = hubcontext;
            this.cache = cache;
        }

        public async Task<bool> SetTripAsAvailable ( Trip newtrip, Driver driver )
        {
            if (driver == null || newtrip == null) { return false; }

            if (driver.Status == DriverStatus.Panned) { return false; }

            if (newtrip.Status == TripStatus.InProgress || newtrip.Status == TripStatus.Cancelled) { return false; }

            driver.Trips.Add(newtrip);
            await usermanger.UpdateAsync(driver);
            return true;
        }


        public async Task<ConfirmTripResponse?> ConfirmTrip ( confirmTripDto model, string DriverId )
        {
            var confirmedTrip = new ConfirmTripResponse();
            var Trip = context.Trips.FirstOrDefault(x => x.Id == model.TripId);

            if (Trip == null) { return null; }

            var driver = context.Drivers.FirstOrDefault(x => x.Id == DriverId);

            if (driver == null) { return null; }

            confirmedTrip.TripId = Trip.Id;
            confirmedTrip.DriverName = driver.UserName!;
            confirmedTrip.Price = model.Price;
            confirmedTrip.DriverPhoneNumber = driver.PhoneNumber;
            confirmedTrip.UserPhoneNumber = model.PhoneNumber;
            confirmedTrip.CarName = driver.CarName;
            confirmedTrip.DriverId = DriverId;
            confirmedTrip.UserLatitude = Trip.PickupLocation.Latitude;
            confirmedTrip.UserLongitude = Trip.PickupLocation.Longitude;
            confirmedTrip.DriverLatitude = driver.Location!.Latitude;
            confirmedTrip.DriverLongitude = driver.Location.Longitude;

            return confirmedTrip;
        }

        public async Task<List<Driver>> GetNearsetDriversAsync ( LocationDTO model, CancellationToken cancelToken )
        {
            var nearsetDrivers = new List<Driver>();

            double MaxDistance = 2;

            var Drivers = await context.Drivers.ToListAsync();

            nearsetDrivers = Drivers
                .Where(x => x.Location != null && Getdistance(x.Location.Latitude, x.Location.Longitude, model.Latitude, model.Longitude) <= MaxDistance)
                .ToList();

            return nearsetDrivers;
        }

        public async Task<bool> MakeMeOfflineAsync ( string DriverId )
        {
            var driverUser = await usermanger.FindByIdAsync(DriverId);


            if (driverUser == null) { return false; }

            var driver = context.Drivers.FirstOrDefault(x => x.Id == driverUser.Id);

            driver.ConnectionId = null;
            driver.Status = DriverStatus.Offline;
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> MakeMeOnlineAsync ( string DriverId, string connectionId )
        {
            if (connectionId == null) { return false; }

            var driverUser = await usermanger.FindByIdAsync(DriverId);


            if (driverUser == null) { return false; }

            var driver = context.Drivers.FirstOrDefault(x => x.Id == driverUser.Id);

            if (driver.Status == DriverStatus.Pending || driver.Status == DriverStatus.Panned) { return false; }

            driver.ConnectionId = connectionId;
            driver.Status = DriverStatus.Online;

            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateDriverLocationAsync ( string Id, DriverLocation model )
        {
            if (model == null) { return false; }

            var driver = await usermanger.FindByIdAsync(Id);

            var driverInfo = context.Drivers.Include(x => x.Trips).FirstOrDefault(x => x.Id == Id);

            if (driverInfo.Status == DriverStatus.Panned || driverInfo.Status == DriverStatus.Offline || driverInfo.Status == DriverStatus.Pending) { return false; }

            var PhoneNumbers = driverInfo.Trips.Select(x => x.Phonenumber).ToList();

            foreach (var phoneNumber in PhoneNumbers)
            {
                await hubcontext.Clients.Group($"User {phoneNumber}")
                     .SendAsync("NewDriverLocation", new { Latitude = model.Latitude, Longitude = model.Longitude, Id });
            }

            driverInfo.Location!.Longitude = model.Longitude;
            driverInfo!.Location!.Latitude = model.Latitude;
            await context.SaveChangesAsync();
            return true;
        }

        private double Getdistance ( double lat1, double lon1, double lat2, double lon2 )
        {
            var R = 6371;
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double ToRadians ( double degree )
        {
            return degree * Math.PI / 180.0;
        }

        public async Task<List<OrderTripDTO>> AvilableTrips ( string DriverId )
        {
            List<OrderTripDTO> result = new();

            var driverfounded = await usermanger.FindByIdAsync(DriverId!);

            var driver = context.Drivers.Include(x => x.Trips).FirstOrDefault(x => x.Id == DriverId);

            if (driver == null || driver.Status == DriverStatus.Panned)
            {
                return result;
            }

            result = context.Trips
                            .Where(x => x.Status != TripStatus.Cancelled && x.Status != TripStatus.InProgress)
                            .ProjectToType<OrderTripDTO>()
                            .ToList();

            return result;
        }

        public async Task<Result> SendMessage ( DriverSendMSGDTO model )
        {
            var user = usermanger.Users.FirstOrDefault(x => x.PhoneNumber == model.PhoneNumber);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            if (user.UserStatus == UserStatus.Panned) { return Result.Failure(UserErrors.DisabledUser); }

            await hubcontext.Clients.Group($"User {model.PhoneNumber}")
                .SendAsync("DriverMSG", new { model.Message });
            return Result.Success();
        }

        public async Task<Result> DriverRegister ( DriverRegisterDTO model )
        {
            var driver = await usermanger.FindByEmailAsync(model.Email!);

            if (driver != null)
            {
                var DriverInfo = context.Drivers.FirstOrDefault(x => x.Id == driver!.Id);
                if (DriverInfo.CompleltedSteps == 1)
                {
                    if (model.FaceID == null || model.FaceID.Length == 0)
                    { return Result.Failure(DriverErrors.FaceIdNotFound); }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.FaceIdUrl}{model.FaceID.FileName}");

                    using (var Stream = new FileStream(path, FileMode.Create))
                    {
                        await model.FaceID.CopyToAsync(Stream);
                    }

                    DriverInfo.DriverFaceID = $"{Urls.FaceIdUrl}{model.FaceID.FileName}";
                    DriverInfo.CompleltedSteps = 2;
                    await context.SaveChangesAsync();
                    return Result.Success();
                }
                else if (DriverInfo.CompleltedSteps == 2)
                {
                    if (model.CarImages == null || model.CarImages.Count == 0)
                    { return Result.Failure(DriverErrors.CarImagesNotFound); }

                    foreach (var CarImage in model.CarImages)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverCarImages}{CarImage.FileName}");

                        using (var Stream = new FileStream(path, FileMode.Create))
                        {
                            await CarImage.CopyToAsync(Stream);
                        }

                        DriverInfo.CarImage.Add(new VehicleImage
                        {
                            ImageUrl = $"{Urls.DriverCarImages}{CarImage.FileName}"
                        });
                    }
                    DriverInfo.CompleltedSteps = 3;
                    await context.SaveChangesAsync();
                    return Result.Success();
                }

                else if (DriverInfo.CompleltedSteps == 3)
                {
                    if (model.DriverLicense == null || model.DriverLicense.Length == 0)
                    { return Result.Failure(DriverErrors.DriverLicenseNotFound); }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverLicenseUrl}{model.DriverLicense.FileName}");

                    using (var Stream = new FileStream(path, FileMode.Create))
                    {
                        await model.DriverLicense.CopyToAsync(Stream);
                    }

                    DriverInfo.DriverLicense = $"{Urls.DriverLicenseUrl}{model.DriverLicense.FileName}";
                    DriverInfo.CompleltedSteps = 3;
                    await context.SaveChangesAsync();
                    return Result.Success();
                }

                else if (DriverInfo.CompleltedSteps == 4)
                {
                    if (model.CriminalRecord == null || model.CriminalRecord.Length == 0)
                    { return Result.Failure(DriverErrors.CreminalRecordNotFound); }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CriminalRecord}{model.CriminalRecord.FileName}");

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.CriminalRecord.CopyToAsync(stream);
                    }

                    DriverInfo.CriminalRecord = $"{Urls.CriminalRecord}{model.CriminalRecord.FileName}";
                    await context.SaveChangesAsync();
                    return Result.Success();
                }
                else if (DriverInfo.CompleltedSteps == 5)
                {
                    if (model.CarLicenseImages == null || model.CarLicenseImages.Count == 0)
                    { return Result.Failure(DriverErrors.CarLicenseNotFound); }

                    if (model.CarLicenseImages.Count == 1)
                    { return Result.Failure(DriverErrors.CarLicenseNotFound); }

                    foreach (var CarLicense in model.CarLicenseImages)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarLicenseUrl}{CarLicense.FileName}");

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await CarLicense.CopyToAsync(stream);
                        }

                        DriverInfo.CarLicense.Add(new CarlicenseImage
                        {
                            ImageUrl = $"{Urls.CarLicenseUrl}{CarLicense.FileName}"
                        });
                    }
                    DriverInfo.CompleltedSteps = 4;
                    await context.SaveChangesAsync();
                    return Result.Success();
                }

            }

            Driver newdriver = new();
            newdriver.UserName = model.UserName;
            newdriver.Email = model.Email;
            newdriver.PhoneNumber = model.PhoneNumber;

            if (model.Image == null || model.Image.Length == 0)
            { return Result.Failure(DriverErrors.DriverImageNotFound); }

            var path2 = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverImages}{model.Image.FileName}");

            using (var Stream = new FileStream(path2, FileMode.Create))
            {
                await model.Image.CopyToAsync(Stream);
            }



            var res = await usermanger.CreateAsync(newdriver, model.Password);

            if (!res.Succeeded)
            {
                return Result.Failure(DriverErrors.DriverAddedError);
            }

            var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
            var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

            if (!model.Email.IsValidEmail())
            {
                return Result.Failure(UserErrors.InvalidOTP);
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            string subject = "🔐 Your Tripix OTP Code";

            var otp = GenerateOtp();




            string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "Driver_Email_OTP.html");
            string template = System.IO.File.ReadAllText(templatepath);
            string body = template.Replace("{{otp}}", otp);


            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "Tripix Support"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.ReplyToList.Add(new MailAddress(fromEmail));
            mailMessage.Headers.Add("X-Priority", "1");
            mailMessage.Headers.Add("X-MSMail-Priority", "High");
            mailMessage.Headers.Add("Importance", "High");
            mailMessage.To.Add(model.Email);
            await smtpClient.SendMailAsync(mailMessage);

            var otpObject = new OTPObject
            {
                OTP = otp
            };
            var CacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(DateTime.Now.AddDays(1).Subtract(DateTime.Now).TotalSeconds),
                SlidingExpiration = null
            };

            var jsonData = JsonConvert.SerializeObject(otpObject);
            await cache.SetStringAsync($"OTP{newdriver.Name}", jsonData, CacheOptions);





            await usermanger.AddToRoleAsync(newdriver, "Driver");
            var refreshToken = GenerateRefreshToken();

            var reftoken = new RefreshTokens()
            {
                RefreshToken = refreshToken.RefreshToken,
                ExpiredDate = refreshToken.ExpiredDate,
                CreatedDate = refreshToken.CreatedDate,

            };

            newdriver.REFTokens!.Add(reftoken);
            await usermanger.UpdateAsync(newdriver);

            var DriverInfo2 = context.Drivers.FirstOrDefault(x => x.Id == newdriver.Id);


            DriverInfo2.CompleltedSteps = 1;
            DriverInfo2.DriverImage = $"{Urls.DriverImages}{model.Image.FileName}";
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<Result> UpdateDriverData ( string DriverId, UpdateDriverData model )
        {
            var driver = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == DriverId);

            if (driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            model.Adapt(driver);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<DriverResponse>> GetDriverData ( string DriverId )
        {
            var Driver = await context.Drivers
                .Where(x => x.Id == DriverId)
                .ProjectToType<DriverResponse>()
                .FirstOrDefaultAsync();

            if (Driver == null) { return Result.Failure<DriverResponse>(DriverErrors.DriverNotFound); }

            return Result.Success(Driver);
        }

        public async Task<List<DriverResponse>> GetDrivers ()
        {
            var Drivers = await context.Drivers
                .AsQueryable()
                .ProjectToType<DriverResponse>()
                .ToListAsync();

            return Drivers;
        }

        public async Task<Result> AcceptDriver ( string DriverId )
        {
            var Driver = await context.Drivers.FirstOrDefaultAsync(x => x.Id == DriverId);

            if (Driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if (Driver.Status == DriverStatus.Confirmed) { return Result.Failure(DriverErrors.AlreadyConfirmedDriver); }

            if (Driver.Status == DriverStatus.Rejected) { return Result.Failure(DriverErrors.RejectedDriver); }

            Driver.Status = DriverStatus.Confirmed;
            await context.SaveChangesAsync();
            return Result.Success();

        }

        public async Task<Result> RejectDriver ( string DriverId )
        {
            var Driver = await context.Drivers.FirstOrDefaultAsync(x => x.Id == DriverId);

            if (Driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if (Driver!.Status == DriverStatus.Confirmed) { return Result.Failure(DriverErrors.AlreadyConfirmedDriver); }

            if (Driver.Status == DriverStatus.Rejected) { return Result.Failure(DriverErrors.RejectedDriver); }

            Driver.Status = DriverStatus.Rejected;
            await context.SaveChangesAsync();
            return Result.Success();
        }



        private RefreshTokens GenerateRefreshToken ()
        {
            return new RefreshTokens
            {
                RefreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                ExpiredDate = DateTime.UtcNow.AddDays(15),
                CreatedDate = DateTime.UtcNow,
            };

        }
        private string GenerateOtp ( int length = 4 )
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }
}
