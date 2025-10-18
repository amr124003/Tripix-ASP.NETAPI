using Mapster;
using System.Data;
using Tripix.Abstractions.Consts;
using Tripix.Contracts.Admin;
using Tripix.Contracts.Car;
using Tripix.Contracts.CarRental;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.DA;
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
using Tripix.Extentions;
using Tripix.View_Models;

namespace Tripix.Mapping
{
    public class MappingConfiguration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterModel, ApplicationUser>()
                .Map(dest => dest.UserName, src => src.Username)
                .Map(dest => dest.PhoneNumber, src => src.Phone)
                .Map(dest => dest.Email, src => src.Email);


            config.NewConfig<OrderHelpooDTO, HelpooOrders>();

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
                .Map(dest => dest.Name, src => src.CarName)
                .Map(dest => dest.Year, src => src.CarYear)
                .Map(dest => dest.Model, src => src.CarModel)
                .Map(dest => dest.Prand, src => src.CarPrand)
                .Map(dest => dest.Price, src => src.CarPrice)
                .Map(dest => dest.Description, src => src.CarDescription);


            TypeAdapterConfig<Car, CarResponse>.NewConfig()
                .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));

            TypeAdapterConfig<UsedVehicle, CarResponse>.NewConfig()
                .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));

            TypeAdapterConfig<Motorbikes, Motorbikeresponse>.NewConfig()
                .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));


            TypeAdapterConfig<ElectricCars, ElectricCarsResponse>.NewConfig()
               .Map(dest => dest.ImagesUrls, src => src.VehicleImages.Select(x => x.ImageUrl));


            TypeAdapterConfig<SpareParts, SparePartResponse>.NewConfig()
                .Map(dest => dest.Images, src => src.Images.Select(x => x.ImageUrl));


            config.NewConfig<Car, FavouriteProduct>()
                .Map(dest => dest.Image , src => src.VehicleImages.First().ImageUrl)
                ;

            TypeAdapterConfig<CarBrand, BrandDto>.NewConfig()
                .Map(dest => dest.BrandName, src => src.Name)
                .Map(dest => dest.Models, src => src.Models.Select(x => x.Name))
                .Map(dest => dest.Expanded, src => src.Expand);

            config.NewConfig<AddCarForRent, CarsForrRent>();

            config.NewConfig<CarsForrRent, CarForRentResponse>();

            config.NewConfig<RentCarDTO, CarRent>()
                .Map(dest => dest.TenantName, src => src.Name)
                .Map(dest => dest.TenantPhone, src => src.Phone)
                .Map(dest => dest.CarID, src => src.CarId)
                .Map(dest => dest.StartDate, src => src.StartDate)
                .Map(dest => dest.EndDate, src => src.EndDate);

            config.NewConfig<UpdateCarForRentDTO, CarsForrRent>();

            config.NewConfig<BookingTurnDTO, RepairBookings>()
                  .Map(dest => dest.CarType, src => (CarFuelTypes)Enum.Parse(typeof(CarFuelTypes), src.CarType))
                  .Map(dest => dest.PricingPlan, src => (PricingPlan)Enum.Parse(typeof(PricingPlan), src.PricingPlan));

            config.NewConfig<UpdateCar, Car>()
                .Map(dest => dest.Name, src => src.CarName)
                .Map(dest => dest.Year, src => src.CarYear)
                .Map(dest => dest.Model, src => src.CarModel)
                .Map(dest => dest.Prand, src => src.CarPrand)
                .Map(dest => dest.Price, src => src.CarPrice)
                .Map(dest => dest.Description, src => src.CarDescription)
                .Map(dest => dest.Color, src => src.CarColor); 



            TypeAdapterConfig<RepairBookings, CarRepairResponse>.NewConfig()
                .Map(dest => dest.CarType , src => src.CarType.ToString())
                .Map(dest => dest.PrisingPaln , src => src.PricingPlan.ToString());

            config.NewConfig<UpdateTurnDTO, RepairBookings>();

            TypeAdapterConfig<Trip, OrderTripDTO>.NewConfig()
                .Map(dest => dest.TripId, src => src.Id)
                .Map(dest => dest.PickupLatitude, src => src.PickupLocation.Latitude)
                .Map(dest => dest.PickupLongitude, src => src.PickupLocation.Longitude)
                .Map(dest => dest.DestinationLatitude, src => src.DestinationLocation.Latitude)
                .Map(dest => dest.DestinationLongitude, src => src.DestinationLocation.Longitude)
                .Map(dest => dest.FirstName, src => src.FirstName)
                .Map(dest => dest.LastName, src => src.LastName)
                .Map(dest => dest.PhoneNumber, src => src.Phonenumber)
                .Map(dest => dest.TripDate, src => src.TripDate);

            config.NewConfig<DriverRegisterDTO, Driver>();


            config.NewConfig<AddMotorbikeDTO, Motorbikes>()
                .Map(dest => dest.Name, src => src.MotorbikeName)
                .Map(dest => dest.Model, src => src.MotorbikeModel)
                .Map(dest => dest.Year, src => src.MotorbikeYear)
                .Map(dest => dest.Description, src => src.MotorbikeDescription)
                .Map(dest => dest.Price, src => src.MotorbikePrice)
                .Map(dest => dest.Prand, src => src.MotorbikePrand)
                .Map(dest => dest.MotorbikeType , src => src.MotorbikeTypes);


            config.NewConfig<UpdateMotorbikeDTO, Motorbikes>()
                .Map(dest => dest.Name, src => src.MotorbikeName)
                .Map(dest => dest.Model, src => src.MotorbikeModel)
                .Map(dest => dest.Year, src => src.MotorbikeYear)
                .Map(dest => dest.Description, src => src.MotorbikeDescription)
                .Map(dest => dest.Price, src => src.MotorbikePrice)
                .Map(dest => dest.Prand, src => src.MotorbikePrand);

            config.NewConfig<Vehicle, VehicleResponse>();

            config.NewConfig<AddElectricCatDTO, ElectricCars>()
                .Map(dest => dest.Name, src => src.CarName)
                .Map(dest => dest.Year, src => src.CarYear)
                .Map(dest => dest.Model, src => src.CarModel)
                .Map(dest => dest.Color, src => src.CarColor)
                .Map(dest => dest.Description, src => src.CarDescription)
                .Map(dest => dest.Prand, src => src.CarPrand)
                .Map(dest => dest.Price, src => src.CarPrice)
                .Map(dest => dest.Power, src => src.CarPower);

            config.NewConfig<AddWashDTO, WashBooking>();

            config.NewConfig<UpdateDriverData, ApplicationUser>();

            TypeAdapterConfig<Driver, DriverResponse>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.DriverImage, src => src.DriverImage)
                .Map(dest => dest.CarImages, src => src.CarImage.Select(x => x.ImageUrl))
                .Map(dest => dest.CarLicense, src => src.CarLicense.Select(x => x.ImageUrl))
                .Map(dest => dest.DriverLicense, src => src.DriverLicense)
                .Map(dest => dest.CreminalRecord , src => src.CriminalRecord)
                .Map(dest => dest.DriverFaceId, src => src.DriverFaceID)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.CarModel, src => src.CarModel)
                .Map(dest => dest.CarName, src => src.CarName)
                .Map(dest => dest.DriverStatus, src => src.Status.ToString())
                .Map(dest => dest.Tripcounter, src => src.Trips.Count());

            config.NewConfig<UpdateElectricCarDto, ElectricCars>()
                .Map(dest => dest.Name, src => src.CarName)
                .Map(dest => dest.Year, src => src.CarYear)
                .Map(dest => dest.Model, src => src.CarModel)
                .Map(dest => dest.Description, src => src.CarDescription)
                .Map(dest => dest.Prand, src => src.CarPrand)
                .Map(dest => dest.Price, src => src.CarPrice)
                .Map(dest => dest.Power, src => src.CarPower);

            TypeAdapterConfig<Vehicle, DAResponse>.NewConfig()
                .Map(dest => dest.Type, src => src.GetType().Name)
                .Map(dest => dest.CarImage, src => src.VehicleImages.Select(x => x.ImageUrl).First());

            TypeAdapterConfig<Vehicle, ProductResponse>.NewConfig()
                .Map(dest => dest.Type, src => src.GetType().Name)
                .Map(dest => dest.ProductImages, src => src.VehicleImages.Select(x => x.ImageUrl).First());


            config.NewConfig<AddEventDTO, Event>()
                .Map(dest => dest.Location , src => src.EventLatitude)
                .Map(dest => dest.Location , src => src.EventLongitude);


            config.NewConfig<BookingEventDTO, EventTickets>();
            config.NewConfig<UpdateTicketDTO, EventTickets>();
            config.NewConfig<UpdateEventDTO, Event>()
                 .Map(dest => dest.Location, src => src.EventLatitude)
                 .Map(dest => dest.Location, src => src.EventLongitude);

            TypeAdapterConfig<Vehicle, ProductSearchResponse>.NewConfig();
            

            

            config.NewConfig<AddJopDTO, Jop>();

            TypeAdapterConfig<JopApplications, JopApplicationResponse>.NewConfig();

            config.NewConfig<UpdateJopDTO, Jop>();

            config.NewConfig<AddSparePartDTO, SpareParts>();

            config.NewConfig<UpdateSparePart, SpareParts>();

            config.NewConfig<AddTipDTO, Tip>();

            config.NewConfig<UpdateTipDTO, Tip>();

            config.NewConfig<UpdateCommentDTO, TipComments>();

            config.NewConfig<SellCarDto, UsedVehicle>()
                .Map(dest => dest.Name, src => src.CarName)
                .Map(dest => dest.Model, src => src.CarModel)
                .Map(dest => dest.Description , src => src.CarDescription)
                .Map(dest => dest.CarType , src => src.CarTypes)
                .Map(dest => dest.Gearbox_Type , src => src.GearboxTypes)
                .Map(dest => dest.FuelType , src => src.CarFuelTypes)
                .Map(dest => dest.CarLocation!.Latitude, src => src.Location_Latitude)
                .Map(dest => dest.CarLocation!.Longitude, src => src.Location_Longitude);

            config.NewConfig<DriverRegisterDTO, Driver>()
                .Map(dest => dest.Name, src => src.UserName.GetNameFromUserName());

            
        }
    }
}
