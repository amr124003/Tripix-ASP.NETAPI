using Mapster;
using Tripix.Abstractions.Consts;
using Tripix.Contracts;
using Tripix.Contracts.Admin;
using Tripix.Contracts.Car;
using Tripix.Contracts.CarRental;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.Driver;
using Tripix.Contracts.ElectricCar;
using Tripix.Contracts.Event;
using Tripix.Contracts.Jop;
using Tripix.Contracts.Motorbikes;
using Tripix.Contracts.SpareParts;
using Tripix.Contracts.Tips;
using Tripix.Contracts.Trip;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Mapping
{
    public class MappingConfiguration : IRegister
    {
        public void Register ( TypeAdapterConfig config )
        {
            config.NewConfig<RegisterModel, ApplicationUser>()
                .Map(dest => dest.UserName, src => src.Username)
                .Map(dest => dest.PhoneNumber, src => src.Phone)
                .Map(dest => dest.Email, src => src.Email);

            config.NewConfig<OrderTripDTO, Trip>()
                .Map(dest => dest.PickupLocation.Longitude, src => src.PickupLongitude)
                .Map(dest => dest.PickupLocation.Latitude, src => src.PickupLatitude)
                .Map(dest => dest.DestinationLocation.Longitude, src => src.DestinationLongitude)
                .Map(dest => dest.DestinationLocation.Latitude, src => src.DestinationLatitude)
                .Map(dest => dest.FirstName, src => src.FirstName)
                .Map(dest => dest.LastName, src => src.LastName)
                .Map(dest => dest.Phonenumber, src => src.PhoneNumber);

            config.NewConfig<TripResponse, Trip>()
                .Map(dest => dest.TripDate, src => src.TripDate)
                .Map(dest => dest.FirstName, src => src.UserName)
                .Map(x => x.Phonenumber, src => src.PhoneNumber)
                .Map(x => x.DestinationLocation.Latitude, src => src.DestinationLatitude)
                .Map(x => x.DestinationLocation.Longitude, src => src.DestinationLongitude)
                .Map(x => x.PickupLocation.Latitude, src => src.PickupLatitude)
                .Map(dest => dest.PickupLocation.Longitude, src => src.PickupLongitude);

            config.NewConfig<Trip, TripResponse>()
                .Map(dest => dest.TripDate, src => src.TripDate)
                .Map(dest => dest.UserName, src => src.FirstName)
                .Map(dest => dest.PhoneNumber, src => src.Phonenumber)
                .Map(dest => dest.DestinationLatitude, src => src.DestinationLocation.Latitude)
                .Map(dest => dest.DestinationLongitude, src => src.DestinationLocation.Longitude)
                .Map(dest => dest.PickupLatitude, src => src.PickupLocation.Latitude)
                .Map(dest => dest.PickupLongitude, src => src.PickupLocation.Longitude);

            config.NewConfig<ApplicationUser, GetAdminsResponse>();

            config.NewConfig<BlogDTO, Blog>()
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.Content, src => src.Content);

            config.NewConfig<UpdateBlogDto, Blog>()
                .Map(dest => dest.Title, src => src.Title)
                .Map(dest => dest.Content, src => src.Content);

            config.NewConfig<CarDTO, Car>()
                .Map(dest => dest.Gearbox_Type, src => Enum.Parse<GearboxTypes>(src.Gearbox_Type));



            TypeAdapterConfig<Car, CarResponse>.NewConfig()
                .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));

            TypeAdapterConfig<Motorbikes, Motorbikeresponse>.NewConfig()
                .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));


            TypeAdapterConfig<ElectricCars, ElectricCarsResponse>.NewConfig()
               .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));


            TypeAdapterConfig<SpareParts, SparePartResponse>.NewConfig()
                .Map(dest => dest.Images, src => src.Images.Select(x => x.ImageUrl));


            config.NewConfig<Car, FavouriteProduct>();

            TypeAdapterConfig<CarBrand, BrandDto>.NewConfig()
                .Map(dest => dest.BrandName, src => src.Name)
                .Map(dest => dest.Models, src => src.Models.Select(x => x.Name))
                .Map(dest => dest.Expanded, src => src.Expand);

            config.NewConfig<AddCarforRent, CarsForrRent>();

            config.NewConfig<CarsForrRent, CarForRentResponse>();

            config.NewConfig<RentCarDTO, CarRent>()
                .Map(dest => dest.TenantName, src => src.Name)
                .Map(dest => dest.TenantEmail, src => src.Email)
                .Map(dest => dest.TenantPhone, src => src.Phone)
                .Map(dest => dest.CarID, src => src.CarId)
                .Map(dest => dest.StartDate, src => src.StartDate)
                .Map(dest => dest.EndDate, src => src.EndDate);

            config.NewConfig<UpdateCarForRentDTO, CarsForrRent>();

            config.NewConfig<BookingTurnDTO, RepairBookings>();

            config.NewConfig<RepairBookings, CarRepairResponse>();

            config.NewConfig<UpdateTurnDTO, RepairBookings>();

            TypeAdapterConfig<Trip, OrderTripDTO>.NewConfig()
                .Map(src => src.TripId, dest => dest.Id)
                .Map(src => src.PickupLatitude, dest => dest.PickupLocation.Latitude)
                .Map(src => src.PickupLongitude, dest => dest.PickupLocation.Longitude)
                .Map(src => src.DestinationLatitude, dest => dest.DestinationLocation.Latitude)
                .Map(src => src.DestinationLongitude, dest => dest.DestinationLocation.Longitude)
                .Map(src => src.FirstName, dest => dest.FirstName)
                .Map(src => src.LastName, dest => dest.LastName)
                .Map(src => src.PhoneNumber, dest => dest.Phonenumber)
                .Map(src => src.TripDate, dest => dest.TripDate);

            config.NewConfig<DriverRegisterDTO, Driver>();

            config.NewConfig<Motorbikes, Motorbikeresponse>();

            config.NewConfig<Motorbikes, AddmotorbikesDTO>();

            config.NewConfig<UpdateMotorbikeDTO, Motorbikes>();

            config.NewConfig<Vehicle, VehicleResponse>();

            config.NewConfig<AddElectricCatDTO, ElectricCars>();

            config.NewConfig<AddWashDTO, WashBooking>();

            config.NewConfig<UpdateDriverData, ApplicationUser>();

            TypeAdapterConfig<Driver, DriverResponse>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.DriverImage, src => src.DriverImage)
                .Map(dest => dest.CarImages, src => src.CarImage.Select(x => x.ImageUrl))
                .Map(dest => dest.CarLicense, src => src.CarLicense.Select(x => x.ImageUrl))
                .Map(dest => dest.DriverLicense, src => src.DriverLicense)
                .Map(dest => dest.DriverFaceId, src => src.DriverFaceID)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.CarModel, src => src.CarModel)
                .Map(dest => dest.CarName, src => src.CarName)
                .Map(dest => dest.DriverStatus, src => src.Status.ToString())
                .Map(dest => dest.Tripcounter, src => src.Trips.Count());

            config.NewConfig<UpdateElectricCarDto, ElectricCars>();

            TypeAdapterConfig<Vehicle, DAResponse>.NewConfig()
                .Map(dest => dest.Type, src => src.GetType().Name)
                .Map(dest => dest.CarImage, src => src.VehicleImages.Select(x => x.ImageUrl).First());

            config.NewConfig<AddEventDTO, Event>();
            config.NewConfig<BookingEventDTO, EventTickets>();
            config.NewConfig<UpdateTicketDTO, EventTickets>();
            config.NewConfig<UpdateEventDTO, Event>();

            config.NewConfig<JopApplications, JopApplicationResponse>();

            config.NewConfig<AddJopDTO, Jop>();

            TypeAdapterConfig<JopApplications, JopApplicationResponse>.NewConfig();

            config.NewConfig<UpdateJopDTO, Jop>();

            config.NewConfig<AddSparePartDTO, SpareParts>();

            config.NewConfig<UpdateSparePart ,  SpareParts>();
            
            config.NewConfig<AddTipDTO , Tip>();

            config.NewConfig<UpdateTipDTO , Tip>();

            config.NewConfig<UpdateCommentDTO, TipComments>();
        }
    }
}
