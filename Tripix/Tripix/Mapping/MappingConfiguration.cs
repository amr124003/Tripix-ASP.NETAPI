using Mapster;
using Tripix.Abstractions.Consts;
using Tripix.Contracts.Admin;
using Tripix.Contracts.Car;
using Tripix.Contracts.CarRental;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.Driver;
using Tripix.Contracts.ElectricCar;
using Tripix.Contracts.Motorbikes;
using Tripix.Contracts.Trip;
using Tripix.Contracts.Vehicle;
using Tripix.Contracts.Wash;
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

            

            config.NewConfig<UpdateElectricCarDto, ElectricCars>();
        }
    }
}
