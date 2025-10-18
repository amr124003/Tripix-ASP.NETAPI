using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Transactions;
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
using Tripix.Services.Interfaces;
using Tripix.View_Models;
using static System.Net.Mime.MediaTypeNames;

namespace Tripix.Services.Repositories
{
    public class DriverRepo : IDriverRepo
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly IJwtProvider jwtProvider;
        private readonly IHubContext<UserHub> hubcontext;
        private readonly IDistributedCache cache;
        private readonly RoleManager<IdentityRole> rolemanger;

        public DriverRepo(ApplicationDbcontext context, UserManager<ApplicationUser> usermanger, IJwtProvider jwtProvider, IHubContext<UserHub> hubcontext, IDistributedCache cache, RoleManager<IdentityRole> rolemanger)
        {
            this.context = context;
            this.usermanger = usermanger;
            this.jwtProvider = jwtProvider;
            this.hubcontext = hubcontext;
            this.cache = cache;
            this.rolemanger = rolemanger;
        }

        public async Task<bool> SetTripAsAvailable(Trip newtrip, Driver driver)
        {
            if (driver == null || newtrip == null) { return false; }

            if (driver.Status == DriverStatus.Panned) { return false; }

            if (newtrip.Status == TripStatus.InProgress || newtrip.Status == TripStatus.Cancelled) { return false; }

            driver.Trips.Add(newtrip);
            await usermanger.UpdateAsync(driver);
            return true;
        }


        public async Task<ConfirmTripResponse?> ConfirmTrip(confirmTripDto model, string DriverId)
        {
            var confirmedTrip = new ConfirmTripResponse();
            var Trip = context.Trips.FirstOrDefault(x => x.Id == model.TripId);

            if (Trip == null) { return null; }

            var driver = usermanger.Users.OfType<Driver>().FirstOrDefault(x => x.Id == DriverId);

            if (driver == null) { return null; }

            confirmedTrip.TripId = Trip.Id;
            confirmedTrip.DriverName = driver.UserName!;
            confirmedTrip.Price = model.Price;
            confirmedTrip.DriverPhoneNumber = driver.PhoneNumber;
            confirmedTrip.UserPhoneNumber = model.PhoneNumber;
            confirmedTrip.CarName = driver.CarName!;
            confirmedTrip.DriverId = DriverId;
            confirmedTrip.UserLatitude = Trip.PickupLocation.Latitude;
            confirmedTrip.UserLongitude = Trip.PickupLocation.Longitude;
            confirmedTrip.DriverLatitude = driver.Location!.Latitude;
            confirmedTrip.DriverLongitude = driver.Location.Longitude;

            driver.AcceptCount++;
            await context.SaveChangesAsync();

            return confirmedTrip;
        }



        public async Task<List<Driver>> GetNearsetDriversAsync(LocationDTO model, CancellationToken cancelToken)
        {
            var nearsetDrivers = new List<Driver>();

            double MaxDistance = 2;

            var Drivers = await usermanger.Users.OfType<Driver>().ToListAsync();

            nearsetDrivers = Drivers
                .Where(x => x.Location != null && Getdistance(x.Location.Latitude, x.Location.Longitude, model.Latitude, model.Longitude) <= MaxDistance)
                .ToList();

            return nearsetDrivers;
        }

        public async Task<bool> MakeMeOfflineAsync(string DriverId)
        {
            var driverUser = await usermanger.FindByIdAsync(DriverId);


            if (driverUser == null) { return false; }

            var driver = usermanger.Users.OfType<Driver>().FirstOrDefault(x => x.Id == driverUser.Id);

            driver!.ConnectionId = null;
            driver.Status = DriverStatus.Offline;
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> MakeMeOnlineAsync(string DriverId, string connectionId)
        {
            if (connectionId == null) { return false; }

            var driverUser = await usermanger.FindByIdAsync(DriverId);


            if (driverUser == null) { return false; }

            var driver = usermanger.Users.OfType<Driver>().FirstOrDefault(x => x.Id == driverUser.Id);

            if (driver!.Status == DriverStatus.Pending || driver.Status == DriverStatus.Panned) { return false; }

            driver.ConnectionId = connectionId;
            driver.Status = DriverStatus.Online;

            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateDriverLocationAsync(string Id, DriverLocation model)
        {
            if (model == null) { return false; }

            var driver = await usermanger.FindByIdAsync(Id);

            var driverInfo = usermanger.Users.OfType<Driver>().Include(x => x.Trips).FirstOrDefault(x => x.Id == Id);

            if (driverInfo!.Status == DriverStatus.Panned || driverInfo.Status == DriverStatus.Offline || driverInfo.Status == DriverStatus.Pending) { return false; }

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

        private double Getdistance(double lat1, double lon1, double lat2, double lon2)
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

        private double ToRadians(double degree)
        {
            return degree * Math.PI / 180.0;
        }

        public async Task<List<OrderTripDTO>> AvilableTrips(string DriverId)
        {
            List<OrderTripDTO> result = new();

            var driverfounded = await usermanger.FindByIdAsync(DriverId!);

            var driver = usermanger.Users.OfType<Driver>().Include(x => x.Trips).FirstOrDefault(x => x.Id == DriverId);

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

        public async Task<Result> SendMessage(DriverSendMSGDTO model)
        {
            var user = usermanger.Users.FirstOrDefault(x => x.PhoneNumber == model.PhoneNumber);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            if (user.UserStatus == UserStatus.Panned) { return Result.Failure(UserErrors.DisabledUser); }

            await hubcontext.Clients.Group($"User {model.PhoneNumber}")
                .SendAsync("DriverMSG", new { model.Message });
            return Result.Success();
        }

        public async Task<Result> DriverRegister(string? DriverId, DriverRegisterDTO model)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                if (DriverId != null)
                {
                    var driverUser = await usermanger.FindByIdAsync(DriverId!);

                    Driver? driverEntity = null;

                    if (driverUser != null)
                    {

                        driverEntity = await usermanger.Users.OfType<Driver>().FirstOrDefaultAsync(x => x.Id == driverUser.Id);

                        if (driverEntity == null)
                        {

                            driverEntity = new Driver
                            {
                                Id = driverUser.Id,
                                Email = driverUser.Email,
                                UserName = driverUser.UserName,
                                PhoneNumber = driverUser.PhoneNumber
                            };

                            await usermanger.CreateAsync(driverEntity, model.Password);
                            await context.SaveChangesAsync();
                        }


                        if (driverEntity.CompleltedSteps == 1)
                        {

                            if (model.FaceID == null || model.FaceID.Length == 0)
                                return Result.Failure(DriverErrors.FaceIdNotFound);

                            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.FaceIdUrl}{model.FaceID.FileName}");

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await model.FaceID.CopyToAsync(stream);
                            }

                            driverEntity.DriverFaceID = $"{Urls.SaveFaceIdUrl}{model.FaceID.FileName}";
                            driverEntity.CompleltedSteps = 2;

                            await context.SaveChangesAsync();
                            await transaction.CommitAsync();

                            return Result.Success();
                        }
                        else if (driverEntity.CompleltedSteps == 2)
                        {

                            if (model.CarImages == null || model.CarImages.Count == 0)
                                return Result.Failure(DriverErrors.CarImagesNotFound);

                            foreach (var carImage in model.CarImages)
                            {
                                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverCarImages}{carImage.FileName}");

                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    await carImage.CopyToAsync(stream);
                                }

                                driverEntity.CarImage.Add(new VehicleImage
                                {
                                    ImageUrl = $"{Urls.SaveDriverCarImages}{carImage.FileName}"
                                });
                            }

                            driverEntity.CompleltedSteps = 3;

                            await context.SaveChangesAsync();
                            await transaction.CommitAsync();

                            return Result.Success();
                        }
                        else if (driverEntity.CompleltedSteps == 3)
                        {

                            if (model.DriverLicense == null || model.DriverLicense.Length == 0)
                                return Result.Failure(DriverErrors.DriverLicenseNotFound);

                            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverLicenseUrl}{model.DriverLicense.FileName}");

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await model.DriverLicense.CopyToAsync(stream);
                            }

                            driverEntity.DriverLicense = $"{Urls.SaveDriverLicenseUrl}{model.DriverLicense.FileName}";
                            driverEntity.CompleltedSteps = 4;

                            await context.SaveChangesAsync();
                            await transaction.CommitAsync();

                            return Result.Success();
                        }
                        else if (driverEntity.CompleltedSteps == 4)
                        {

                            if (model.CriminalRecord == null || model.CriminalRecord.Length == 0)
                                return Result.Failure(DriverErrors.CreminalRecordNotFound);

                            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CriminalRecord}{model.CriminalRecord.FileName}");

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await model.CriminalRecord.CopyToAsync(stream);
                            }

                            driverEntity.CriminalRecord = $"{Urls.SaveCriminalRecord}{model.CriminalRecord.FileName}";
                            driverEntity.CompleltedSteps = 5;

                            await context.SaveChangesAsync();
                            await transaction.CommitAsync();

                            return Result.Success();
                        }
                        else if (driverEntity.CompleltedSteps == 5)
                        {

                            if (model.CarLicenseImages == null || model.CarLicenseImages.Count < 2)
                                return Result.Failure(DriverErrors.CarLicenseNotFound);

                            foreach (var carLicense in model.CarLicenseImages)
                            {
                                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarLicenseUrl}{carLicense.FileName}");

                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    await carLicense.CopyToAsync(stream);
                                }

                                driverEntity.CarLicense.Add(new CarlicenseImage
                                {
                                    ImageUrl = $"{Urls.SaveCarLicenseUrl}{carLicense.FileName}"
                                });
                            }

                            driverEntity.CompleltedSteps = 6;

                            await context.SaveChangesAsync();
                            await transaction.CommitAsync();

                            return Result.Success();
                        }
                    }

                }



                var existingUserName = await usermanger.FindByNameAsync(model.UserName) ?? await usermanger.FindByEmailAsync(model.Email);
                if (existingUserName != null)
                    return Result.Failure(UserErrors.DuplicatedEmail);



                var newDriver = model.Adapt<Driver>();


                if (model.Image == null || model.Image.Length == 0)
                    return Result.Failure(DriverErrors.DriverImageNotFound);

                var uniqueFileName = $"{Guid.NewGuid()}_{model.Image.FileName}";
                var imgPath = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarImageUrl}{uniqueFileName}");

                using (var stream = new FileStream(imgPath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }


                var res = await usermanger.CreateAsync(newDriver, model.Password!);

                if (!res.Succeeded)
                    return Result.Failure(DriverErrors.DriverAddedError);


                var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
                var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

                if (!model.Email.IsValidEmail())
                    return Result.Failure(UserErrors.InvalidOTP);

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true,
                };

                string subject = "🔐 Your Tripix OTP Code";
                var otp = GenerateOtp();

                string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "Driver_Email_OTP.html");
                string template = System.IO.File.ReadAllText(templatePath);
                string body = template.Replace("{{otp}}", otp);

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail!, "Tripix Support"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(model.Email!);
                await smtpClient.SendMailAsync(mailMessage);


                var otpObject = new OTPObject { OTP = otp };
                var cacheOptions = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1),
                };

                var jsonData = JsonConvert.SerializeObject(otpObject);
                await cache.SetStringAsync($"OTP_{newDriver.Name}", jsonData, cacheOptions);


                await usermanger.AddToRoleAsync(newDriver, "Driver");


                var refreshToken = GenerateRefreshToken();

                newDriver.REFTokens!.Add(new RefreshTokens
                {
                    RefreshToken = refreshToken.RefreshToken,
                    ExpiredDate = refreshToken.ExpiredDate,
                    CreatedDate = refreshToken.CreatedDate
                });


                newDriver.CompleltedSteps = 1;
                newDriver.DriverImage = $"{Urls.SaveDriverImages}{uniqueFileName}";

                await usermanger.UpdateAsync(newDriver);
                await transaction.CommitAsync();
                return Result.Success();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"Error: {ex.Message}");
                return Result.Failure(DriverErrors.ErrorOnRegister);
            }
        }


        public async Task<Result> RejectTrip(string DriverId, int TripIId)
        {
            var Driver = await usermanger.Users.OfType<Driver>().FirstOrDefaultAsync(x => x.Id == DriverId);

            if (Driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if (Driver.Status == DriverStatus.Panned) { return Result.Failure(DriverErrors.PanneddDriver); }

            if (!Driver.EmailConfirmed) { return Result.Failure(DriverErrors.UnconfirmedEmail); }

            var Trip = Driver.Trips.FirstOrDefault(x => x.Id == TripIId);

            if (Trip == null)
            {
                Driver.CancellationCount++;
            }
            else
            {
                Driver.RejectAfterAccept++;
                Trip.Status = TripStatus.Pending;

            }
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> UpdateDriverData(string DriverId, UpdateDriverData model)
        {
            var driver = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == DriverId);

            if (driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if (await usermanger.IsInRoleAsync(driver, "Driver"))
            {
                using var Transaction = context.Database.BeginTransaction();
                try
                {
                    model.Adapt(driver);

                    var DriverInfo = await usermanger.Users.OfType<Driver>().FirstOrDefaultAsync(x => x.Id == driver.Id);

                    if (DriverInfo!.DriverImage != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), DriverInfo.DriverImage);

                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }

                    var newpath = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.DriverImages}{model.DriverImage.FileName}");

                    using (var Stream = new FileStream(newpath, FileMode.Create))
                    {
                        await model.DriverImage.CopyToAsync(Stream);
                    }
                    DriverInfo.DriverImage = $"{Urls.DriverImages}{model.DriverImage.FileName}";
                    await context.SaveChangesAsync();
                    return Result.Success();
                }
                catch
                {
                    await Transaction.RollbackAsync();
                    return Result.Failure(DriverErrors.CannotUpdate);
                }

            }
            else
            {
                return Result.Failure(DriverErrors.CannotUpdate);
            }

        }

        public async Task<List<DriverResponse>> GetDriverApplication(CancellationToken canToken)
        {
            var res = await usermanger.Users.OfType<Driver>()
                .Where(x => x.IsConfirmed == false || x.IsConfirmed == null)
                .ProjectToType<DriverResponse>()
                .ToListAsync(canToken);

            return res;
        }

        

        public async Task<Result<DriverResponse>> GetDriverData(string DriverId)
        {
            var Driver = await usermanger.Users.OfType<Driver>()
                .Where(x => x.Id == DriverId)
                .ProjectToType<DriverResponse>()
                .FirstOrDefaultAsync();

            if (Driver == null) { return Result.Failure<DriverResponse>(DriverErrors.DriverNotFound); }

            return Result.Success(Driver);
        }

        public async Task<List<DriverResponse>> GetDrivers()
        {
            var Drivers = await usermanger.Users.OfType<Driver>()
                .Where(x => x.IsConfirmed == true)
                .ProjectToType<DriverResponse>()
                .ToListAsync();

            return Drivers;
        }

        public async Task<Result> AcceptDriver(string DriverId)
        {
            var Driver = await usermanger.Users.OfType<Driver>().FirstOrDefaultAsync(x => x.Id == DriverId);

            if (Driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if(Driver.IsConfirmed)
            {
                return Result.Failure(DriverErrors.AlreadyConfirmedDriver);
            }

            Driver.IsConfirmed = true;
            await context.SaveChangesAsync();
            return Result.Success();

        }

        public async Task<Result> RejectDriver(string DriverId)
        {
            var Driver = await usermanger.Users.OfType<Driver>().FirstOrDefaultAsync(x => x.Id == DriverId);

            if (Driver == null) { return Result.Failure(DriverErrors.DriverNotFound); }

            if (Driver.IsConfirmed)
            {
                return Result.Failure(DriverErrors.AlreadyConfirmedDriver);
            }
            
            context.Users.Remove(Driver);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        private RefreshTokens GenerateRefreshToken()
        {
            return new RefreshTokens
            {
                RefreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                ExpiredDate = DateTime.UtcNow.AddDays(15),
                CreatedDate = DateTime.UtcNow,
            };

        }
        private string GenerateOtp(int length = 4)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }
}
