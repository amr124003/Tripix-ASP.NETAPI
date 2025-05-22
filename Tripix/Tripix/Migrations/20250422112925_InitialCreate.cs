using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bestSellervehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bestSellervehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expand = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarsForrRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsForrRents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "varchar(19)", unicode: false, maxLength: 19, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardHolderName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ExpiryDate = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CVV = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelpooOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpooOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JopApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JopApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairBookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Car_Gearbox_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car_Rate = table.Column<int>(type: "int", nullable: true),
                    CarType1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car_Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Merchant_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Merchant_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Merchant_Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car_Motor_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryCapacity = table.Column<int>(type: "int", nullable: true),
                    ElectricCars_Gearbox_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelRange = table.Column<int>(type: "int", nullable: true),
                    ElectricCars_Rate = table.Column<int>(type: "int", nullable: true),
                    Interior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargingTime = table.Column<int>(type: "int", nullable: true),
                    Power = table.Column<int>(type: "int", nullable: true),
                    ElectricCars_CarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricCars_Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MotorbikeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motorbikes_Rate = table.Column<int>(type: "int", nullable: true),
                    Motorbikes_Motor_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motorbikes_Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TruckType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    LoadCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Truck_Motor_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsedCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KilometersDriven = table.Column<int>(type: "int", nullable: true),
                    Gearbox_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwenerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwenerPhonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwenerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwenerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwenerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motor_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WashBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashBookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverFaceID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriminalRecord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Latitude = table.Column<double>(type: "float", nullable: false),
                    Location_Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PickupLocation_Latitude = table.Column<double>(type: "float", nullable: false),
                    PickupLocation_Longitude = table.Column<double>(type: "float", nullable: false),
                    DestinationLocation_Latitude = table.Column<double>(type: "float", nullable: false),
                    DestinationLocation_Longitude = table.Column<double>(type: "float", nullable: false),
                    TripDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trip_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModel_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarRents_CarsForrRents_CarID",
                        column: x => x.CarID,
                        principalTable: "CarsForrRents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingEventTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingEventTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingEventTickets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SparePartOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartsId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SparePartOrders_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleBookings_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarlicenseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarlicenseImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarlicenseImage_Drivers_DriverId1",
                        column: x => x.DriverId1,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DriverlicenseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverlicenseImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverlicenseImage_Drivers_DriverId1",
                        column: x => x.DriverId1,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: true),
                    DriverId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleImages_Drivers_DriverId1",
                        column: x => x.DriverId1,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImages_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImages_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Expand", "Name", "NameAR" },
                values: new object[,]
                {
                    { 1, false, "Toyota", "تويوتا" },
                    { 2, false, "Hyundai", "هيونداي" },
                    { 3, false, "Nissan", "نيسان" },
                    { 4, false, "Kia", "كيا" },
                    { 5, false, "Chevrolet", "شيفروليه" },
                    { 6, false, "Mercedes", "مرسيدس" },
                    { 7, false, "BMW", "بي إم دبليو" },
                    { 8, false, "Honda", "هوندا" },
                    { 9, false, "Ford", "فورد" },
                    { 10, false, "Jeep", "جيب" },
                    { 11, false, "Audi", "أودي" },
                    { 12, false, "Mazda", "مازدا" },
                    { 13, false, "Land Rover", "لاند روفر" },
                    { 14, false, "Porsche", "بورش" },
                    { 15, false, "Lexus", "لكزس" },
                    { 16, false, "Jaguar", "جاكوار" },
                    { 17, false, "Volvo", "فولفو" },
                    { 18, false, "Mitsubishi", "ميتسوبيشي" },
                    { 19, false, "Subaru", "سوبارو" },
                    { 20, false, "Peugeot", "بيجو" },
                    { 21, false, "Renault", "رينو" },
                    { 22, false, "Fiat", "فيات" },
                    { 23, false, "Opel", "أوبل" },
                    { 24, false, "Suzuki", "سوزوكي" },
                    { 25, false, "Seat", "سيات" },
                    { 26, false, "MG", "إم جي" },
                    { 27, false, "Geely", "جيلي" },
                    { 28, false, "BYD", "بي واي دي" },
                    { 29, false, "JAC", "جاك" },
                    { 30, false, "Chery", "شيري" },
                    { 31, false, "Jetour", "جيتور" },
                    { 32, false, "Speranza", "سبيرانزا" },
                    { 33, false, "BAIC", "بايك" },
                    { 34, false, "Daewoo", "دايو" },
                    { 35, false, "Dongfeng", "دونغ فينغ" },
                    { 36, false, "DFSK", "دي إف إس كيه" },
                    { 37, false, "FAW", "فاو" },
                    { 38, false, "Foton", "فوتون" },
                    { 39, false, "Lifan", "ليفان" },
                    { 40, false, "Proton", "بروتون" },
                    { 41, false, "Shalaby", "شلبي" },
                    { 42, false, "Dayun", "دايون" },
                    { 43, false, "Volkswagen", "فولكس واجن" },
                    { 44, false, "Skoda", "سكودا" },
                    { 45, false, "Tesla", "تسلا" },
                    { 46, false, "Rivian", "ريفيان" },
                    { 47, false, "Lucid Motors", "لوسيد موتورز" },
                    { 48, false, "NIO", "نيو" },
                    { 49, false, "XPeng", "إكس بنج" },
                    { 50, false, "Fisker", "فيسكر" },
                    { 51, false, "Polestar", "بولستار" },
                    { 52, false, "Faraday Future", "فاراداي فيوتشر" },
                    { 53, false, "VinFast", "فينفاست" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Response", "question" },
                values: new object[,]
                {
                    { 1, "سجل حساب على المنصة، وروح لقسم 'بيع سيارة'، واملأ البيانات المطلوبة وارفع صور للعربية.", "إزاي أبيع عربيتي؟" },
                    { 2, "مش إجباري، لكن الكشف بيدي مصداقية أعلى وبيساعد في البيع أسرع.", "هل لازم أكشف على العربية قبل البيع؟" },
                    { 3, "أيوه، المنصة بتاخد عمولة بسيطة بعد إتمام عملية البيع بنجاح.", "فيه عمولة على البيع؟" },
                    { 4, "ادخل على قسم 'تأجير السيارات'، اختار العربية والتاريخ واضغط حجز.", "إزاي أأجر عربية؟" },
                    { 5, "أيوه، كل العربيات المؤجرة بيكون عليها تأمين شامل طول فترة الإيجار.", "هل فيه تأمين على العربيات؟" },
                    { 6, "أيوه، بس ممكن يتخصم رسوم حسب سياسة الإلغاء الخاصة بالعربية.", "هل أقدر أرجّع العربية قبل المعاد؟" },
                    { 7, "أيوه، من خلال قسم 'الصيانة' تقدر تختار نوع الخدمة وتحجز معاد.", "هل أقدر أطلب صيانة للعربية؟" },
                    { 8, "أيوه، تابع العروض في الصفحة الرئيسية أو في الإشعارات.", "هل فيه خصومات على غسيل العربية؟" },
                    { 9, "أيوه، بنغطي أغلب المحافظات، وبنتوسع بشكل مستمر.", "هل الونش بيشتغل في كل مكان؟" },
                    { 10, "أيوه، قدم على وظيفة من خلال صفحة 'الوظائف' وسجل بياناتك.", "هل فيه وظيفة سواق متاحة؟" },
                    { 11, "Create an account on the platform, go to the 'Sell Car' section, fill in the required details, and upload photos of your car.", "How can I sell my car?" },
                    { 12, "It's not mandatory, but inspection increases credibility and helps you sell faster.", "Do I need to inspect the car before selling?" },
                    { 13, "Yes, the platform takes a small commission after the sale is completed.", "Is there a commission on selling?" },
                    { 14, "Go to the 'Car Rental' section, choose the car and date, then click Book.", "How can I rent a car?" },
                    { 15, "Yes, all rental cars come with full insurance during the rental period.", "Is insurance included with rental cars?" },
                    { 16, "Yes, but there might be a cancellation fee depending on the car's policy.", "Can I return the car earlier than scheduled?" },
                    { 17, "Yes, from the 'Car Maintenance' section you can select the service type and book an appointment.", "Can I request car maintenance?" },
                    { 18, "Yes, keep an eye on offers on the homepage or through notifications.", "Are there discounts on car wash services?" },
                    { 19, "Yes, we cover most regions and we are continuously expanding.", "Does the towing service cover all areas?" },
                    { 20, "Yes, you can apply for driver positions from the 'Jobs' page and submit your details.", "Are there any driver job openings?" },
                    { 21, "قم بإنشاء حساب على المنصة، ثم انتقل إلى قسم 'بيع سيارة'، واملأ البيانات المطلوبة وارفع صور السيارة.", "كيف يمكنني بيع سيارتي؟" },
                    { 22, "الفحص ليس إلزامياً، ولكنه يزيد من مصداقية الإعلان ويساعد في بيع السيارة بشكل أسرع.", "هل يجب فحص السيارة قبل بيعها؟" },
                    { 23, "نعم، المنصة تحصل على عمولة بسيطة بعد إتمام عملية البيع بنجاح.", "هل توجد عمولة على عملية البيع؟" },
                    { 24, "انتقل إلى قسم 'تأجير السيارات'، واختر السيارة والتاريخ، ثم اضغط على زر الحجز.", "كيف يمكنني استئجار سيارة؟" },
                    { 25, "نعم، جميع السيارات المؤجرة تشمل تأميناً شاملاً طوال مدة الإيجار.", "هل يشمل تأجير السيارات التأمين؟" },
                    { 26, "نعم، ولكن قد يتم خصم رسوم حسب سياسة الإلغاء الخاصة بالسيارة.", "هل يمكنني إعادة السيارة قبل الموعد المحدد؟" },
                    { 27, "نعم، يمكنك من خلال قسم 'الصيانة' اختيار نوع الخدمة وحجز موعد مناسب.", "هل يمكنني طلب خدمة صيانة للسيارة؟" },
                    { 28, "نعم، تابع العروض من خلال الصفحة الرئيسية أو الإشعارات.", "هل توجد خصومات على خدمات غسيل السيارات؟" },
                    { 29, "نعم، نحن نغطي معظم المناطق ونعمل على التوسع بشكل مستمر.", "هل خدمة الونش متاحة في جميع المناطق؟" },
                    { 30, "نعم، يمكنك التقديم على وظيفة من خلال صفحة 'الوظائف' وتسجيل بياناتك.", "هل توجد وظائف متاحة لسائقي السيارات؟" },
                    { 31, "قم بإنشاء حساب على المنصة، ثم انتقل إلى قسم 'بيع سيارة'، واملأ البيانات المطلوبة وارفع صور السيارة.", "إزاي أبيع عربيتي على المنصة؟" },
                    { 32, "Create an account on the platform, go to the 'Sell Car' section, fill in the required details and upload the car images.", "How can I sell my car on the platform?" },
                    { 33, "قم بإنشاء حساب على المنصة، ثم انتقل إلى قسم 'بيع سيارة'، واملأ البيانات المطلوبة وارفع صور السيارة.", "كيف يمكنني بيع سيارتي على المنصة؟" },
                    { 34, "الفحص ليس إلزامياً، ولكنه يزيد من مصداقية الإعلان ويساعد في بيع السيارة بشكل أسرع.", "هل يجب فحص السيارة قبل بيعها؟" },
                    { 35, "Inspection is not mandatory, but it increases credibility and helps sell the car faster.", "Do I need to inspect the car before selling?" },
                    { 36, "الفحص ليس إلزامياً، ولكنه يزيد من مصداقية الإعلان ويساعد في بيع السيارة بشكل أسرع.", "هل يجب فحص السيارة قبل بيعها؟" },
                    { 37, "نعم، المنصة تحصل على عمولة بسيطة بعد إتمام عملية البيع بنجاح.", "هل توجد عمولة على عملية البيع؟" },
                    { 38, "Yes, the platform takes a small commission after the sale is completed successfully.", "Is there a commission on the sale?" },
                    { 39, "نعم، المنصة تحصل على عمولة بسيطة بعد إتمام عملية البيع بنجاح.", "هل توجد عمولة على عملية البيع؟" },
                    { 40, "انتقل إلى قسم 'تأجير السيارات'، واختر السيارة والتاريخ، ثم اضغط على زر الحجز.", "كيف يمكنني استئجار سيارة؟" },
                    { 41, "Go to the 'Car Rental' section, choose the car and date, then click the book button.", "How can I rent a car?" },
                    { 42, "انتقل إلى قسم 'تأجير السيارات'، واختر السيارة والتاريخ، ثم اضغط على زر الحجز.", "كيف يمكنني استئجار سيارة؟" },
                    { 43, "نعم، جميع السيارات المؤجرة تشمل تأميناً شاملاً طوال مدة الإيجار.", "هل يشمل تأجير السيارات التأمين؟" },
                    { 44, "Yes, all rental cars come with full insurance during the rental period.", "Does car rental include insurance?" },
                    { 45, "نعم، جميع السيارات المؤجرة تشمل تأميناً شاملاً طوال مدة الإيجار.", "هل يشمل تأجير السيارات التأمين؟" },
                    { 46, "نعم، ولكن قد يتم خصم رسوم حسب سياسة الإلغاء الخاصة بالسيارة.", "هل يمكنني إعادة السيارة قبل الموعد المحدد؟" },
                    { 47, "Yes, but there may be a cancellation fee depending on the car's policy.", "Can I return the car before the scheduled time?" },
                    { 48, "نعم، ولكن قد يتم خصم رسوم حسب سياسة الإلغاء الخاصة بالسيارة.", "هل يمكنني إعادة السيارة قبل الموعد المحدد؟" },
                    { 49, "نعم، يمكنك من خلال قسم 'الصيانة' اختيار نوع الخدمة وحجز موعد مناسب.", "هل يمكنني طلب خدمة صيانة للسيارة؟" },
                    { 50, "Yes, you can select the service type and book an appointment through the 'Maintenance' section.", "Can I request car maintenance?" },
                    { 51, "نعم، يمكنك من خلال قسم 'الصيانة' اختيار نوع الخدمة وحجز موعد مناسب.", "هل يمكنني طلب خدمة صيانة للسيارة؟" },
                    { 52, "نعم، تابع العروض من خلال الصفحة الرئيسية أو الإشعارات.", "هل توجد خصومات على خدمات غسيل السيارات؟" },
                    { 53, "Yes, keep an eye on offers through the homepage or notifications.", "Are there discounts on car wash services?" },
                    { 54, "نعم، تابع العروض من خلال الصفحة الرئيسية أو الإشعارات.", "هل توجد خصومات على خدمات غسيل السيارات؟" },
                    { 55, "نعم، نحن نغطي معظم المناطق ونعمل على التوسع بشكل مستمر.", "هل خدمة الونش متاحة في جميع المناطق؟" },
                    { 56, "Yes, we cover most regions and are continuously expanding.", "Is the towing service available in all areas?" },
                    { 57, "نعم، نحن نغطي معظم المناطق ونعمل على التوسع بشكل مستمر.", "هل خدمة الونش متاحة في جميع المناطق؟" },
                    { 58, "نعم، يمكنك التقديم على وظيفة من خلال صفحة 'الوظائف' وتسجيل بياناتك.", "هل توجد وظائف متاحة لسائقي السيارات؟" },
                    { 59, "Yes, you can apply for a driver position through the 'Jobs' page and submit your details.", "Are there driver job openings?" },
                    { 60, "نعم، يمكنك التقديم على وظيفة من خلال صفحة 'الوظائف' وتسجيل بياناتك.", "هل توجد وظائف متاحة لسائقي السيارات؟" },
                    { 61, "نعم، يمكنك تعديل الصور في أي وقت من خلال صفحة إدارة الإعلانات.", "هل يمكنني تعديل صور السيارة بعد نشر الإعلان؟" },
                    { 62, "Yes, you can edit the images anytime from the ad management page.", "Can I edit car images after posting the ad?" },
                    { 63, "نعم، يمكنك تعديل الصور في أي وقت من خلال صفحة إدارة الإعلانات.", "هل يمكنني تعديل صور السيارة بعد نشر الإعلان؟" },
                    { 64, "يشترط أن يكون عمرك فوق 21 سنة وأن تكون لديك رخصة قيادة سارية.", "ما هي شروط تأجير السيارات؟" },
                    { 65, "You must be over 21 years old and have a valid driving license.", "What are the conditions for renting a car?" },
                    { 66, "يشترط أن يكون عمرك فوق 21 سنة وأن تكون لديك رخصة قيادة سارية.", "ما هي شروط تأجير السيارات؟" },
                    { 67, "نعم، تتوفر لدينا سيارات أوتوماتيكية للإيجار.", "هل تتوفر سيارات أوتوماتيكية للتأجير؟" },
                    { 68, "Yes, we have automatic cars available for rent.", "Are automatic cars available for rental?" },
                    { 69, "نعم، تتوفر لدينا سيارات أوتوماتيكية للإيجار.", "هل تتوفر سيارات أوتوماتيكية للتأجير؟" },
                    { 70, "في حال حدوث أي عطل، يرجى الاتصال بخدمة العملاء للتوجيه والإصلاح.", "ماذا أفعل إذا تعطلت السيارة أثناء فترة الإيجار؟" },
                    { 71, "In case of breakdown, please contact customer service for guidance and repair.", "What should I do if the car breaks down during rental?" },
                    { 72, "في حال حدوث أي عطل، يرجى الاتصال بخدمة العملاء للتوجيه والإصلاح.", "ماذا أفعل إذا تعطلت السيارة أثناء فترة الإيجار؟" },
                    { 73, "خدمات الصيانة تتم في مراكز معتمدة ويمكنك تحديد موعد الصيانة عبر التطبيق.", "أين تتم خدمات الصيانة وكم من الوقت تستغرق؟" },
                    { 74, "Maintenance services are carried out at authorized centers, and you can schedule an appointment through the app.", "Where do maintenance services take place and how long do they take?" },
                    { 75, "خدمات الصيانة تتم في مراكز معتمدة ويمكنك تحديد موعد الصيانة عبر التطبيق.", "أين تتم خدمات الصيانة وكم من الوقت تستغرق؟" },
                    { 76, "يمكنك طلب الخدمة من خلال التطبيق في قسم 'الونش'.", "كيف يمكنني طلب خدمة السحب (الونش)؟" },
                    { 77, "You can request the towing service through the app in the 'Towing' section.", "How can I request the towing service?" },
                    { 78, "يمكنك طلب الخدمة من خلال التطبيق في قسم 'الونش'.", "كيف يمكنني طلب خدمة السحب (الونش)؟" },
                    { 79, "نعم، يمكنك حجز خدمة غسيل السيارة عبر التطبيق في أي وقت.", "هل يمكنني حجز خدمة غسيل السيارة من خلال التطبيق؟" },
                    { 80, "Yes, you can book the car wash service anytime through the app.", "Can I book a car wash service through the app?" },
                    { 81, "نعم، يمكنك حجز خدمة غسيل السيارة عبر التطبيق في أي وقت.", "هل يمكنني حجز خدمة غسيل السيارة من خلال التطبيق؟" },
                    { 82, "نعم، نقدم قطع غيار أصلية لجميع أنواع السيارات.", "هل تتوفر قطع غيار أصلية؟" },
                    { 83, "Yes, we provide original spare parts for all types of cars.", "Are original spare parts available?" },
                    { 84, "نعم، نقدم قطع غيار أصلية لجميع أنواع السيارات.", "هل تتوفر قطع غيار أصلية؟" },
                    { 85, "نعم، يوجد قسم خاص بفعاليات السيارات يمكن من خلاله الاطلاع على الفعاليات القادمة.", "هل يوجد قسم خاص بفعاليات السيارات؟" },
                    { 86, "Yes, there is a dedicated section for car events where you can check upcoming events.", "Is there a section for car events?" },
                    { 87, "نعم، يوجد قسم خاص بفعاليات السيارات يمكن من خلاله الاطلاع على الفعاليات القادمة.", "هل يوجد قسم خاص بفعاليات السيارات؟" },
                    { 88, "نعم، يمكنك التقديم على وظائف مبتدئة، ونحن نوفر تدريباً شاملاً.", "هل يمكنني التقديم على وظيفة دون خبرة سابقة؟" },
                    { 89, "Yes, you can apply for entry-level jobs, and we provide comprehensive training.", "Can I apply for a job without prior experience?" },
                    { 90, "نعم، يمكنك التقديم على وظائف مبتدئة، ونحن نوفر تدريباً شاملاً.", "هل يمكنني التقديم على وظيفة دون خبرة سابقة؟" },
                    { 91, "لو واجهت أي مشكلة أثناء القيادة، حاول توقف في مكان آمن واتصل بأقرب مركز صيانة أو خدمة طوارئ.", "إزاي أتعامل مع مشكلة في السيارة أثناء القيادة؟" },
                    { 92, "If you encounter any issue while driving, try to stop in a safe place and contact the nearest service center or emergency service.", "What should I do if I face a problem with my car while driving?" },
                    { 93, "لو واجهت أي مشكلة أثناء القيادة، حاول توقف في مكان آمن واتصل بأقرب مركز صيانة أو خدمة طوارئ.", "كيف أتعامل مع مشكلة في السيارة أثناء القيادة؟" },
                    { 94, "نعم، لكن قد يتم فرض رسوم إضافية حسب سياسة الإرجاع الخاصة بكل سيارة.", "هل يمكنني استرجاع السيارة قبل موعد الإرجاع؟" },
                    { 95, "Yes, but extra charges may apply based on the return policy for each car.", "Can I return the car before the return date?" },
                    { 96, "نعم، لكن قد يتم فرض رسوم إضافية حسب سياسة الإرجاع الخاصة بكل سيارة.", "هل يمكنني استرجاع السيارة قبل موعد الإرجاع؟" },
                    { 97, "نعم، نحن نقدم خيارات تأجير قصيرة المدة تبدأ من يوم واحد.", "هل يمكنني تأجير سيارة لفترة قصيرة؟" },
                    { 98, "Yes, we offer short-term rental options starting from one day.", "Can I rent a car for a short period?" },
                    { 99, "نعم، نحن نقدم خيارات تأجير قصيرة المدة تبدأ من يوم واحد.", "هل يمكنني تأجير سيارة لفترة قصيرة؟" },
                    { 100, "نعم، يمكنك تعديل بيانات إعلان السيارة بعد نشره عبر حسابك على المنصة.", "هل يمكنني تعديل بيانات الإعلان بعد نشره؟" },
                    { 101, "Yes, you can edit the car ad details after posting through your account on the platform.", "Can I edit my ad details after posting?" },
                    { 102, "نعم، يمكنك تعديل بيانات إعلان السيارة بعد نشره عبر حسابك على المنصة.", "هل يمكنني تعديل بيانات الإعلان بعد نشره؟" },
                    { 103, "نعم، نحن نقدم دعمًا فنيًا على مدار الساعة من خلال التطبيق أو الموقع الإلكتروني.", "هل يوجد دعم فني 24 ساعة؟" },
                    { 104, "Yes, we offer 24/7 technical support through the app or website.", "Is there 24/7 technical support?" },
                    { 105, "نعم، نحن نقدم دعمًا فنيًا على مدار الساعة من خلال التطبيق أو الموقع الإلكتروني.", "هل يوجد دعم فني 24 ساعة؟" },
                    { 106, "نعم، نحن نقدم خدمة نقل السيارات من وإلى المواقع المختلفة من خلال خدمة الونش.", "هل توفر المنصة خدمات نقل السيارات؟" },
                    { 107, "Yes, we offer car transport services to and from different locations through our towing service.", "Does the platform provide car transport services?" },
                    { 108, "نعم، نحن نقدم خدمة نقل السيارات من وإلى المواقع المختلفة من خلال خدمة الونش.", "هل توفر المنصة خدمات نقل السيارات؟" },
                    { 109, "يمكنك الدفع باستخدام البطاقة الائتمانية أو من خلال خيارات الدفع الإلكتروني الأخرى المتاحة في التطبيق.", "كيف يمكنني الدفع مقابل الخدمات؟" },
                    { 110, "You can pay using a credit card or through other available electronic payment options in the app.", "How can I pay for the services?" },
                    { 111, "يمكنك الدفع باستخدام البطاقة الائتمانية أو من خلال خيارات الدفع الإلكتروني الأخرى المتاحة في التطبيق.", "كيف يمكنني الدفع مقابل الخدمات؟" },
                    { 112, "نعم، يمكنك إضافة أكثر من سيارة للإيجار من خلال حسابك على المنصة.", "هل يمكنني إضافة أكثر من سيارة للإيجار؟" },
                    { 113, "Yes, you can add more than one car for rent through your account on the platform.", "Can I add more than one car for rent?" },
                    { 114, "نعم، يمكنك إضافة أكثر من سيارة للإيجار من خلال حسابك على المنصة.", "هل يمكنني إضافة أكثر من سيارة للإيجار؟" },
                    { 115, "نعم، قد تكون هناك رسوم إضافية حسب نوع الخدمة أو العرض المقدم.", "هل توجد رسوم إضافية على خدمات غسيل السيارات؟" },
                    { 116, "Yes, there may be additional charges depending on the type of service or the offered promotion.", "Are there extra charges for car wash services?" },
                    { 117, "نعم، قد تكون هناك رسوم إضافية حسب نوع الخدمة أو العرض المقدم.", "هل توجد رسوم إضافية على خدمات غسيل السيارات؟" },
                    { 118, "نعم، لدينا قطع غيار لجميع أنواع السيارات بما في ذلك السيارات الفارهة.", "هل توفر المنصة قطع غيار للسيارات الفارهة؟" },
                    { 119, "Yes, we have spare parts for all types of cars, including luxury vehicles.", "Does the platform provide spare parts for luxury cars?" },
                    { 120, "نعم، لدينا قطع غيار لجميع أنواع السيارات بما في ذلك السيارات الفارهة.", "هل توفر المنصة قطع غيار للسيارات الفارهة؟" },
                    { 121, "نعم، لدينا برامج ولاء تقدم خصومات وعروض خاصة للعملاء المتكررين.", "هل توجد برامج ولاء لعملاء الإيجار؟" },
                    { 122, "Yes, we have loyalty programs offering discounts and special offers for repeat customers.", "Are there loyalty programs for rental customers?" },
                    { 123, "نعم، لدينا برامج ولاء تقدم خصومات وعروض خاصة للعملاء المتكررين.", "هل توجد برامج ولاء لعملاء الإيجار؟" },
                    { 124, "يمكنك تقييم الخدمة بعد كل عملية من خلال التطبيق في قسم التقييمات.", "كيف يمكنني تقييم الخدمة؟" },
                    { 125, "You can rate the service after every transaction through the app in the ratings section.", "How can I rate the service?" },
                    { 126, "يمكنك تقييم الخدمة بعد كل عملية من خلال التطبيق في قسم التقييمات.", "كيف يمكنني تقييم الخدمة؟" },
                    { 127, "نعم، يمكنك إلغاء الحجز ولكن سيتم خصم رسوم إلغاء بناءً على سياسة المنصة.", "هل يمكنني إلغاء الحجز بعد الدفع؟" },
                    { 128, "Yes, you can cancel the reservation, but cancellation fees may apply based on the platform's policy.", "Can I cancel the reservation after payment?" },
                    { 129, "نعم، يمكنك إلغاء الحجز ولكن سيتم خصم رسوم إلغاء بناءً على سياسة المنصة.", "هل يمكنني إلغاء الحجز بعد الدفع؟" },
                    { 130, "نعم، يمكنك استئجار سيارات للاستخدام اليومي حسب توفرها.", "هل يمكنني استئجار سيارة للاستخدام اليومي؟" },
                    { 131, "Yes, you can rent cars for daily use based on availability.", "Can I rent a car for daily use?" },
                    { 132, "نعم، يمكنك استئجار سيارات للاستخدام اليومي حسب توفرها.", "هل يمكنني استئجار سيارة للاستخدام اليومي؟" },
                    { 133, "لا، يكفي أن تكون لديك رخصة قيادة سارية المفعول من بلدك.", "هل أحتاج إلى رخصة قيادة دولية للإيجار؟" },
                    { 134, "No, a valid driving license from your country is sufficient.", "Do I need an international driving license to rent a car?" },
                    { 135, "لا، يكفي أن تكون لديك رخصة قيادة سارية المفعول من بلدك.", "هل أحتاج إلى رخصة قيادة دولية للإيجار؟" },
                    { 136, "نعم، تتوفر لدينا سيارات مجهزة بمقاعد للأطفال عند الطلب.", "هل يمكنني استئجار سيارة بمقعد طفل؟" },
                    { 137, "Yes, we offer cars equipped with child seats upon request.", "Can I rent a car with a child seat?" },
                    { 138, "نعم، تتوفر لدينا سيارات مجهزة بمقاعد للأطفال عند الطلب.", "هل يمكنني استئجار سيارة بمقعد طفل؟" },
                    { 139, "نعم، لدينا سيارات رياضية للايجار حسب توفرها.", "هل يمكنني استئجار سيارة رياضية؟" },
                    { 140, "Yes, we have sports cars available for rent based on availability.", "Can I rent a sports car?" },
                    { 141, "نعم، لدينا سيارات رياضية للايجار حسب توفرها.", "هل يمكنني استئجار سيارة رياضية؟" },
                    { 142, "يمكنك إلغاء حسابك من خلال الإعدادات في التطبيق، وسوف نساعدك في إتمام العملية.", "كيف يمكنني إلغاء حسابي؟" },
                    { 143, "You can delete your account through the settings in the app, and we will assist you in the process.", "How can I delete my account?" },
                    { 144, "يمكنك إلغاء حسابك من خلال الإعدادات في التطبيق، وسوف نساعدك في إتمام العملية.", "كيف يمكنني إلغاء حسابي؟" },
                    { 145, "نعم، نحن نوفر خدمة توصيل السيارات إلى الموقع الذي تختاره.", "هل تقدمون خدمة توصيل للسيارات؟" },
                    { 146, "Yes, we provide car delivery services to your chosen location.", "Do you offer car delivery services?" },
                    { 147, "نعم، نحن نوفر خدمة توصيل السيارات إلى الموقع الذي تختاره.", "هل تقدمون خدمة توصيل للسيارات؟" },
                    { 148, "نعم، يمكنك استئجار السيارة لفترة طويلة، ويمكنك التفاوض على السعر.", "هل يمكنني استئجار السيارة لفترة طويلة؟" },
                    { 149, "Yes, you can rent the car for a long period, and you can negotiate the price.", "Can I rent the car for a long period?" },
                    { 150, "نعم، يمكنك استئجار السيارة لفترة طويلة، ويمكنك التفاوض على السعر.", "هل يمكنني استئجار السيارة لفترة طويلة؟" },
                    { 151, "نعم، يمكنك الدفع نقدًا عند استلام السيارة أو الخدمة.", "هل يمكنني الدفع نقدًا؟" },
                    { 152, "Yes, you can pay in cash when receiving the car or service.", "Can I pay in cash?" },
                    { 153, "نعم، يمكنك الدفع نقدًا عند استلام السيارة أو الخدمة.", "هل يمكنني الدفع نقدًا؟" },
                    { 154, "يمكنك متابعة حالة السيارة من خلال التطبيق، حيث ستتمكن من معرفة موعد وصولها أو أي تحديثات أخرى.", "كيف يمكنني متابعة حالة السيارة التي قمت بحجزها؟" },
                    { 155, "You can track the status of your car through the app, where you can check its arrival time and any updates.", "How can I track the status of my booked car?" },
                    { 156, "يمكنك متابعة حالة السيارة من خلال التطبيق، حيث ستتمكن من معرفة موعد وصولها أو أي تحديثات أخرى.", "كيف يمكنني متابعة حالة السيارة التي قمت بحجزها؟" },
                    { 157, "نعم، يمكنك استبدال السيارة خلال فترة الإيجار ولكن بناءً على توافر السيارات والشروط الخاصة.", "هل يمكنني استبدال السيارة خلال فترة الإيجار؟" },
                    { 158, "Yes, you can exchange the car during the rental period, subject to availability and the terms and conditions.", "Can I exchange the car during the rental period?" },
                    { 159, "نعم، يمكنك استبدال السيارة خلال فترة الإيجار ولكن بناءً على توافر السيارات والشروط الخاصة.", "هل يمكنني استبدال السيارة خلال فترة الإيجار؟" },
                    { 160, "نعم، نقدم خصومات خاصة للمجموعات التي تستأجر أكثر من سيارة.", "هل توجد خصومات للمجموعات؟" },
                    { 161, "Yes, we offer special discounts for groups renting more than one car.", "Are there discounts for groups?" },
                    { 162, "نعم، نقدم خصومات خاصة للمجموعات التي تستأجر أكثر من سيارة.", "هل توجد خصومات للمجموعات؟" },
                    { 163, "نعم، يمكنك تحديد نوع السيارة عند الحجز، لكن ذلك يعتمد على التوافر.", "هل يمكنني تحديد نوع السيارة قبل الحجز؟" },
                    { 164, "Yes, you can choose the type of car when booking, but this depends on availability.", "Can I select the type of car before booking?" },
                    { 165, "نعم، يمكنك تحديد نوع السيارة عند الحجز، لكن ذلك يعتمد على التوافر.", "هل يمكنني تحديد نوع السيارة قبل الحجز؟" },
                    { 166, "نعم، يمكنك إلغاء الحجز في أي وقت، ولكن قد يتم فرض رسوم إلغاء حسب سياسة المنصة.", "هل يمكنني إلغاء الحجز في أي وقت؟" },
                    { 167, "Yes, you can cancel the reservation at any time, but cancellation fees may apply based on the platform's policy.", "Can I cancel the reservation at any time?" },
                    { 168, "نعم، يمكنك إلغاء الحجز في أي وقت، ولكن قد يتم فرض رسوم إلغاء حسب سياسة المنصة.", "هل يمكنني إلغاء الحجز في أي وقت؟" },
                    { 169, "نعم، جميع السيارات تأتي مع تأمين شامل للحوادث والضرر.", "هل يوجد تأمين على السيارة؟" },
                    { 170, "Yes, all cars come with comprehensive insurance for accidents and damage.", "Is insurance provided for the car?" },
                    { 171, "نعم، جميع السيارات تأتي مع تأمين شامل للحوادث والضرر.", "هل يوجد تأمين على السيارة؟" },
                    { 172, "نعم، يمكنك تعديل موعد الاستلام من خلال التطبيق قبل الموعد المحدد.", "هل يمكنني تعديل موعد الاستلام؟" },
                    { 173, "Yes, you can modify the pickup time through the app before the scheduled time.", "Can I modify the pickup time?" },
                    { 174, "نعم، يمكنك تعديل موعد الاستلام من خلال التطبيق قبل الموعد المحدد.", "هل يمكنني تعديل موعد الاستلام؟" },
                    { 175, "نعم، يمكنك طلب سيارة مع سائق عبر التطبيق.", "هل يمكنني الحصول على سيارة مع سائق؟" },
                    { 176, "Yes, you can request a car with a driver through the app.", "Can I get a car with a driver?" },
                    { 177, "نعم، يمكنك طلب سيارة مع سائق عبر التطبيق.", "هل يمكنني الحصول على سيارة مع سائق؟" },
                    { 178, "نعم، يمكنك تعديل حجزك ولكن يعتمد ذلك على سياسة المنصة.", "هل يمكنني تعديل حجز السيارة بعد تأكيده؟" },
                    { 179, "Yes, you can modify your reservation, but this depends on the platform's policy.", "Can I modify my car reservation after confirmation?" },
                    { 180, "نعم، يمكنك تعديل حجزك ولكن يعتمد ذلك على سياسة المنصة.", "هل يمكنني تعديل حجز السيارة بعد تأكيده؟" },
                    { 181, "نعم، يمكنك حجز السيارة لمدة عدة أيام وفقًا لاحتياجاتك.", "هل يمكنني حجز سيارة لعدة أيام؟" },
                    { 182, "Yes, you can book the car for several days based on your needs.", "Can I book a car for several days?" },
                    { 183, "نعم، يمكنك حجز السيارة لمدة عدة أيام وفقًا لاحتياجاتك.", "هل يمكنني حجز سيارة لعدة أيام؟" },
                    { 184, "نعم، جميع السيارات تأتي مع ضمان ضد الأعطال التي تحدث خلال فترة الإيجار.", "هل يوجد ضمان للسيارة؟" },
                    { 185, "Yes, all cars come with a warranty against breakdowns during the rental period.", "Is there a warranty for the car?" },
                    { 186, "نعم، جميع السيارات تأتي مع ضمان ضد الأعطال التي تحدث خلال فترة الإيجار.", "هل يوجد ضمان للسيارة؟" },
                    { 187, "يمكنك معرفة حالة الصيانة من خلال التطبيق أو عن طريق التواصل مع فريق الدعم.", "كيف يمكنني معرفة حالة صيانة السيارة؟" },
                    { 188, "You can know the maintenance status through the app or by contacting the support team.", "How can I know the car's maintenance status?" },
                    { 189, "يمكنك معرفة حالة الصيانة من خلال التطبيق أو عن طريق التواصل مع فريق الدعم.", "كيف يمكنني معرفة حالة صيانة السيارة؟" },
                    { 190, "نعم، يمكنك دفع جزء من المبلغ عند الحجز، ثم دفع الباقي عند استلام السيارة.", "هل يمكنني حجز سيارة دون دفع المبلغ بالكامل؟" },
                    { 191, "Yes, you can pay a portion of the amount when booking, and the remainder when receiving the car.", "Can I book a car without paying the full amount?" },
                    { 192, "نعم، يمكنك دفع جزء من المبلغ عند الحجز، ثم دفع الباقي عند استلام السيارة.", "هل يمكنني حجز سيارة دون دفع المبلغ بالكامل؟" },
                    { 193, "نعم، ولكن يعتمد ذلك على توافر السيارات الأخرى. يمكنك التواصل معنا لتعديل الحجز.", "هل يمكنني تغيير نوع السيارة بعد الحجز؟" },
                    { 194, "Yes, but it depends on the availability of other cars. You can contact us to modify the booking.", "Can I change the type of car after booking?" },
                    { 195, "نعم، ولكن يعتمد ذلك على توافر السيارات الأخرى. يمكنك التواصل معنا لتعديل الحجز.", "هل يمكنني تغيير نوع السيارة بعد الحجز؟" },
                    { 196, "نعم، نقدم خدمة توصيل السيارات في معظم المدن التي نعمل بها.", "هل يتم توفير خدمة توصيل للسيارات في جميع المدن؟" },
                    { 197, "Yes, we provide car delivery services in most of the cities we operate in.", "Is car delivery available in all cities?" },
                    { 198, "نعم، نقدم خدمة توصيل السيارات في معظم المدن التي نعمل بها.", "هل يتم توفير خدمة توصيل للسيارات في جميع المدن؟" },
                    { 199, "نعم، يمكنك تعديل وقت التسليم قبل الموعد المحدد من خلال التطبيق.", "هل يمكنني تغيير وقت تسليم السيارة؟" },
                    { 200, "Yes, you can modify the delivery time before the scheduled time through the app.", "Can I change the car delivery time?" },
                    { 201, "نعم، يمكنك تعديل وقت التسليم قبل الموعد المحدد من خلال التطبيق.", "هل يمكنني تغيير وقت تسليم السيارة؟" },
                    { 202, "نعم، ولكن قد تحتاج إلى تقديم تأمين نقدي بدلاً من بطاقة الائتمان.", "هل يمكنني استئجار سيارة بدون بطاقة ائتمان؟" },
                    { 203, "Yes, but you may need to provide a cash deposit instead of a credit card.", "Can I rent a car without a credit card?" },
                    { 204, "نعم، ولكن قد تحتاج إلى تقديم تأمين نقدي بدلاً من بطاقة الائتمان.", "هل يمكنني استئجار سيارة بدون بطاقة ائتمان؟" },
                    { 205, "نعم، لدينا مجموعة من السيارات الفاخرة التي يمكنك استئجارها.", "هل تتوفر سيارات فاخرة للإيجار؟" },
                    { 206, "Yes, we have a selection of luxury cars available for rent.", "Are luxury cars available for rent?" },
                    { 207, "نعم، لدينا مجموعة من السيارات الفاخرة التي يمكنك استئجارها.", "هل تتوفر سيارات فاخرة للإيجار؟" },
                    { 208, "يمكنك طلب خدمة غسيل السيارة من خلال التطبيق أو التواصل مع فريق الدعم.", "كيف يمكنني طلب خدمة غسيل السيارة؟" },
                    { 209, "You can request the car wash service through the app or by contacting the support team.", "How can I request a car wash service?" },
                    { 210, "يمكنك طلب خدمة غسيل السيارة من خلال التطبيق أو التواصل مع فريق الدعم.", "كيف يمكنني طلب خدمة غسيل السيارة؟" },
                    { 211, "نعم، يمكنك طلب خدمات صيانة خلال فترة الإيجار وفقًا للشروط المتاحة.", "هل يمكنني طلب خدمات صيانة أثناء فترة الإيجار؟" },
                    { 212, "Yes, you can request maintenance services during the rental period according to the available terms.", "Can I request maintenance services during the rental period?" },
                    { 213, "نعم، يمكنك طلب خدمات صيانة خلال فترة الإيجار وفقًا للشروط المتاحة.", "هل يمكنني طلب خدمات صيانة أثناء فترة الإيجار؟" },
                    { 214, "نعم، يمكنك تعديل مكان تسليم السيارة إذا كانت الخدمة متاحة في الموقع الجديد.", "هل يمكنني تغيير مكان تسليم السيارة؟" },
                    { 215, "Yes, you can modify the delivery location if the service is available at the new location.", "Can I change the car delivery location?" },
                    { 216, "نعم، يمكنك تعديل مكان تسليم السيارة إذا كانت الخدمة متاحة في الموقع الجديد.", "هل يمكنني تغيير مكان تسليم السيارة؟" },
                    { 217, "نعم، يمكنك حجز السيارة من خلال الموقع الإلكتروني أو التطبيق.", "هل يمكنني حجز سيارة من خلال الموقع الإلكتروني؟" },
                    { 218, "Yes, you can book a car through the website or the app.", "Can I book a car through the website?" },
                    { 219, "نعم، يمكنك حجز السيارة من خلال الموقع الإلكتروني أو التطبيق.", "هل يمكنني حجز سيارة من خلال الموقع الإلكتروني؟" },
                    { 220, "نعم، يمكنك استئجار السيارة لفترة طويلة والسفر بها لأماكن بعيدة.", "هل يمكنني استئجار سيارة لسفر طويل؟" },
                    { 221, "Yes, you can rent the car for a long period and take it on long trips.", "Can I rent a car for a long trip?" },
                    { 222, "نعم، يمكنك استئجار السيارة لفترة طويلة والسفر بها لأماكن بعيدة.", "هل يمكنني استئجار سيارة لسفر طويل؟" },
                    { 223, "يجب أن تكون في سن 25 أو أكثر لاستئجار السيارة، باستثناء بعض الحالات الخاصة.", "هل أستطيع استئجار سيارة بأقل من 25 سنة؟" },
                    { 224, "You must be 25 or older to rent a car, except in some special cases.", "Can I rent a car if I'm under 25?" },
                    { 225, "يجب أن تكون في سن 25 أو أكثر لاستئجار السيارة، باستثناء بعض الحالات الخاصة.", "هل أستطيع استئجار سيارة بأقل من 25 سنة؟" },
                    { 226, "نعم، يمكنك إضافة سائق إضافي مقابل رسوم إضافية.", "هل يمكنني إضافة سائق إضافي؟" },
                    { 227, "Yes, you can add an additional driver for an extra fee.", "Can I add an additional driver?" },
                    { 228, "نعم، يمكنك إضافة سائق إضافي مقابل رسوم إضافية.", "هل يمكنني إضافة سائق إضافي؟" },
                    { 229, "نعم، لدينا سيارات كهربائية متاحة للإيجار.", "هل تقدمون سيارات كهربائية؟" },
                    { 230, "Yes, we have electric cars available for rent.", "Do you offer electric cars?" },
                    { 231, "نعم، لدينا سيارات كهربائية متاحة للإيجار.", "هل تقدمون سيارات كهربائية؟" },
                    { 232, "نعم، جميع السيارات تأتي مع تأمين ضد الحوادث.", "هل يوجد خدمة تأمين ضد الحوادث؟" },
                    { 233, "Yes, all cars come with accident insurance.", "Is there accident insurance available?" },
                    { 234, "نعم، جميع السيارات تأتي مع تأمين ضد الحوادث.", "هل يوجد خدمة تأمين ضد الحوادث؟" },
                    { 235, "نعم، جميع السيارات تأتي مع ضمان ضد الأعطال.", "هل يمكنني استئجار سيارة مع ضمان؟" },
                    { 236, "Yes, all cars come with a warranty against breakdowns.", "Can I rent a car with a warranty?" },
                    { 237, "نعم، جميع السيارات تأتي مع ضمان ضد الأعطال.", "هل يمكنني استئجار سيارة مع ضمان؟" },
                    { 238, "نعم، يمكنك حجز السيارة في وقت لاحق حسب التوافر.", "هل يمكنني حجز سيارة في وقت لاحق؟" },
                    { 239, "Yes, you can book the car at a later time based on availability.", "Can I book a car at a later time?" },
                    { 240, "نعم، يمكنك حجز السيارة في وقت لاحق حسب التوافر.", "هل يمكنني حجز سيارة في وقت لاحق؟" },
                    { 241, "يمكنك إضافة حجز آخر من خلال التطبيق أو الموقع الإلكتروني.", "كيف يمكنني إضافة حجز آخر؟" },
                    { 242, "You can add another reservation through the app or website.", "How can I add another reservation?" },
                    { 243, "يمكنك إضافة حجز آخر من خلال التطبيق أو الموقع الإلكتروني.", "كيف يمكنني إضافة حجز آخر؟" },
                    { 244, "نعم، يمكنك تعديل مواعيد الحجز ولكن وفقًا لسياسة المنصة.", "هل يمكنني تعديل مواعيد الحجز بعد التأكيد؟" },
                    { 245, "Yes, you can modify the reservation dates, but according to the platform's policy.", "Can I modify my reservation dates after confirmation?" },
                    { 246, "نعم، يمكنك تعديل مواعيد الحجز ولكن وفقًا لسياسة المنصة.", "هل يمكنني تعديل مواعيد الحجز بعد التأكيد؟" },
                    { 247, "نعم، نوفر خدمة تأجير سيارات النقل الكبيرة والصغيرة.", "هل توفرون خدمة تأجير سيارات النقل؟" },
                    { 248, "Yes, we offer rental services for both large and small transport vehicles.", "Do you offer rental services for transport vehicles?" },
                    { 249, "نعم، نوفر خدمة تأجير سيارات النقل الكبيرة والصغيرة.", "هل توفرون خدمة تأجير سيارات النقل؟" },
                    { 250, "نعم، توجد سياسات خاصة للإلغاء تشمل الرسوم عند الإلغاء بعد فترة معينة.", "هل هناك سياسات خاصة للإلغاء؟" },
                    { 251, "Yes, there are special cancellation policies that include fees for cancellations after a certain period.", "Are there special cancellation policies?" },
                    { 252, "نعم، توجد سياسات خاصة للإلغاء تشمل الرسوم عند الإلغاء بعد فترة معينة.", "هل هناك سياسات خاصة للإلغاء؟" },
                    { 253, "نعم، يمكنك استئجار السيارة لفترات قصيرة مثل يوم أو يومين.", "هل أستطيع استئجار السيارة لفترة قصيرة؟" },
                    { 254, "Yes, you can rent the car for short periods like a day or two.", "Can I rent the car for a short period?" },
                    { 255, "نعم، يمكنك استئجار السيارة لفترات قصيرة مثل يوم أو يومين.", "هل أستطيع استئجار السيارة لفترة قصيرة؟" },
                    { 256, "نعم، يمكنك تغيير نوع السيارة إذا كانت السيارة الجديدة متاحة.", "هل يمكنني تغيير نوع السيارة أثناء الحجز؟" },
                    { 257, "Yes, you can change the type of car if the new car is available.", "Can I change the type of car during booking?" },
                    { 258, "نعم، يمكنك تغيير نوع السيارة إذا كانت السيارة الجديدة متاحة.", "هل يمكنني تغيير نوع السيارة أثناء الحجز؟" },
                    { 259, "نعم، يمكنك تمديد فترة الإيجار، ولكن بناءً على التوافر.", "هل أستطيع تمديد فترة الإيجار؟" },
                    { 260, "Yes, you can extend the rental period, but subject to availability.", "Can I extend the rental period?" },
                    { 261, "نعم، يمكنك تمديد فترة الإيجار، ولكن بناءً على التوافر.", "هل أستطيع تمديد فترة الإيجار؟" },
                    { 262, "نعم، نقدم تأمين ضد السرقة لجميع السيارات المستأجرة.", "هل يمكنني الحصول على تأمين ضد السرقة؟" },
                    { 263, "Yes, we offer theft insurance for all rented cars.", "Can I get theft insurance?" },
                    { 264, "نعم، نقدم تأمين ضد السرقة لجميع السيارات المستأجرة.", "هل يمكنني الحصول على تأمين ضد السرقة؟" },
                    { 265, "نعم، يمكنك استئجار سيارة للرحلات السياحية والأماكن السياحية.", "هل يمكنني تأجير سيارة للرحلات السياحية؟" },
                    { 266, "Yes, you can rent a car for sightseeing and tourist spots.", "Can I rent a car for sightseeing trips?" },
                    { 267, "نعم، يمكنك استئجار سيارة للرحلات السياحية والأماكن السياحية.", "هل يمكنني تأجير سيارة للرحلات السياحية؟" },
                    { 268, "إذا كنت غير مقيم في البلد، قد تحتاج إلى رخصة قيادة دولية.", "هل أحتاج إلى رخصة قيادة دولية لاستئجار السيارة؟" },
                    { 269, "If you are not a resident of the country, you may need an international driving permit.", "Do I need an international driving permit to rent a car?" },
                    { 270, "إذا كنت غير مقيم في البلد، قد تحتاج إلى رخصة قيادة دولية.", "هل أحتاج إلى رخصة قيادة دولية لاستئجار السيارة؟" },
                    { 271, "أنت ممكن تختار العربية اللي تناسبك من خلال تصفح السيارات المعروضة على المنصة وتعمل حجز أونلاين.", "إزاي أقدر أشتري عربية من المنصة؟" },
                    { 272, "You can choose the car that suits you by browsing the available cars on the platform and making an online reservation.", "How can I buy a car from the platform?" },
                    { 273, "يمكنك اختيار السيارة التي تناسبك من خلال تصفح السيارات المعروضة على المنصة وإجراء حجز إلكتروني.", "كيف يمكنني شراء سيارة من المنصة؟" },
                    { 274, "نعم، يمكنك استئجار سيارة لمدة قصيرة مثل يوم أو يومين، حسب التوافر.", "هل أقدر أستأجر عربية لفترة قصيرة؟" },
                    { 275, "Yes, you can rent a car for a short period like one or two days, depending on availability.", "Can I rent a car for a short period?" },
                    { 276, "نعم، يمكنك استئجار سيارة لفترة قصيرة مثل يوم أو يومين، حسب التوافر.", "هل يمكنني استئجار سيارة لفترة قصيرة؟" },
                    { 277, "يمكنك طلب خدمة الصيانة من خلال التطبيق أو التواصل مع فريق الدعم.", "كيف أقدر أطلب صيانة للسيارة؟" },
                    { 278, "You can request car maintenance service through the app or by contacting the support team.", "How can I request car maintenance?" },
                    { 279, "يمكنك طلب خدمة الصيانة من خلال التطبيق أو التواصل مع فريق الدعم.", "كيف يمكنني طلب صيانة للسيارة؟" },
                    { 280, "نعم، لدينا خدمة غسيل السيارات المتوفرة عبر التطبيق أو من خلال الاتصال المباشر.", "هل يوجد خدمة غسيل سيارات؟" },
                    { 281, "Yes, we have car wash services available through the app or by direct contact.", "Is there a car wash service?" },
                    { 282, "نعم، لدينا خدمة غسيل السيارات المتوفرة عبر التطبيق أو من خلال الاتصال المباشر.", "هل توجد خدمة غسيل سيارات؟" },
                    { 283, "نعم، يمكنك شراء قطع غيار للسيارة عبر قسم قطع الغيار على المنصة.", "هل أقدر أشتري قطع غيار من المنصة؟" },
                    { 284, "Yes, you can buy car parts through the spare parts section on the platform.", "Can I buy car parts from the platform?" },
                    { 285, "نعم، يمكنك شراء قطع غيار من خلال قسم قطع الغيار على المنصة.", "هل يمكنني شراء قطع غيار للسيارة من المنصة؟" },
                    { 286, "نعم، تقوم المنصة بتنظيم فعاليات سيارات مثل معارض السيارات والمهرجانات.", "هل هناك فعاليات سيارات تقام من خلال المنصة؟" },
                    { 287, "Yes, the platform organizes car events like car shows and festivals.", "Are there any car events organized through the platform?" },
                    { 288, "نعم، تقوم المنصة بتنظيم فعاليات سيارات مثل معارض السيارات والمهرجانات.", "هل يتم تنظيم فعاليات سيارات من خلال المنصة؟" },
                    { 289, "يمكنك التقدم لوظيفة سائق من خلال قسم الوظائف على المنصة.", "كيف أقدر أتقدم لوظيفة سائق؟" },
                    { 290, "You can apply for a driver job through the jobs section on the platform.", "How can I apply for a driver job?" },
                    { 291, "يمكنك التقديم لوظيفة سائق من خلال قسم الوظائف على المنصة.", "كيف يمكنني التقدم لوظيفة سائق؟" },
                    { 292, "نعم، نقدم خدمة توصيل السيارات للعملاء في العديد من المناطق.", "هل تقدمون خدمة توصيل للسيارات؟" },
                    { 293, "Yes, we offer car delivery services to customers in many areas.", "Do you offer car delivery service?" },
                    { 294, "نعم، نقدم خدمة توصيل السيارات للعملاء في العديد من المناطق.", "هل تقدمون خدمة توصيل للسيارات؟" },
                    { 295, "نعم، يمكنك إلغاء الحجز ولكن يجب أن تلتزم بسياسات الإلغاء الخاصة بنا.", "هل يمكنني إلغاء الحجز بعد التأكيد؟" },
                    { 296, "Yes, you can cancel your reservation, but you must follow our cancellation policies.", "Can I cancel my reservation after confirmation?" },
                    { 297, "نعم، يمكنك إلغاء الحجز ولكن يجب أن تلتزم بسياسات الإلغاء الخاصة بنا.", "هل يمكنني إلغاء الحجز بعد التأكيد؟" },
                    { 298, "نعم، يمكنك استئجار سيارة لفترات طويلة حسب احتياجاتك.", "هل يمكنني استئجار سيارة لفترات طويلة؟" },
                    { 299, "Yes, you can rent a car for a long period according to your needs.", "Can I rent a car for a long period?" },
                    { 300, "نعم، يمكنك استئجار سيارة لفترات طويلة حسب احتياجاتك.", "هل يمكنني استئجار سيارة لفترات طويلة؟" },
                    { 301, "نعم، يمكنك طلب خدمة صيانة خلال فترة الإيجار إذا لزم الأمر.", "هل يمكنني طلب صيانة للسيارة أثناء فترة الإيجار؟" },
                    { 302, "Yes, you can request maintenance service during the rental period if needed.", "Can I request maintenance for the car during the rental period?" },
                    { 303, "نعم، يمكنك طلب خدمة صيانة خلال فترة الإيجار إذا لزم الأمر.", "هل يمكنني طلب صيانة للسيارة أثناء فترة الإيجار؟" },
                    { 304, "نعم، جميع السيارات مؤمنة ضد السرقة أثناء فترة الإيجار.", "هل يوجد تأمين ضد السرقة للسيارة؟" },
                    { 305, "Yes, all cars are insured against theft during the rental period.", "Is there theft insurance for the car?" },
                    { 306, "نعم، جميع السيارات مؤمنة ضد السرقة أثناء فترة الإيجار.", "هل يوجد تأمين ضد السرقة للسيارة؟" },
                    { 307, "نعم، يمكنك تعديل تفاصيل الحجز إذا تم طلب التعديل قبل موعد الاستلام.", "هل يمكنني تعديل تفاصيل الحجز بعد تأكيده؟" },
                    { 308, "Yes, you can modify your booking details if the modification is requested before the pickup time.", "Can I modify my booking details after confirmation?" },
                    { 309, "نعم، يمكنك تعديل تفاصيل الحجز إذا تم طلب التعديل قبل موعد الاستلام.", "هل يمكنني تعديل تفاصيل الحجز بعد تأكيده؟" },
                    { 310, "يمكنك الدفع عن طريق البطاقة الائتمانية أو الدفع نقدًا عند الاستلام.", "ما هي طرق الدفع المتاحة؟" },
                    { 311, "You can pay by credit card or cash on delivery.", "What payment methods are available?" },
                    { 312, "يمكنك الدفع عن طريق البطاقة الائتمانية أو الدفع نقدًا عند الاستلام.", "ما هي طرق الدفع المتاحة؟" },
                    { 313, "يمكنك حجز السيارة من خلال التطبيق أو الموقع الإلكتروني.", "كيف يمكنني حجز سيارة للإيجار؟" },
                    { 314, "You can rent a car through the app or website.", "How can I rent a car?" },
                    { 315, "يمكنك حجز السيارة من خلال التطبيق أو الموقع الإلكتروني.", "كيف يمكنني حجز سيارة للإيجار؟" },
                    { 316, "نعم، يمكنك شراء موتوسيكلات جديدة أو مستعملة من خلال المنصة.", "هل المنصة بتبيع موتوسيكلات؟" },
                    { 317, "Yes, you can buy new or used motorcycles through the platform.", "Does the platform sell motorcycles?" },
                    { 318, "نعم، يمكنك شراء موتوسيكلات جديدة أو مستعملة من خلال المنصة.", "هل المنصة تبيع موتوسيكلات؟" },
                    { 319, "يمكنك عرض موتوسيكلك للبيع من خلال التطبيق وملء البيانات المطلوبة.", "إزاي أقدر أبيع موتوسيكل على المنصة؟" },
                    { 320, "You can list your motorcycle for sale through the app and fill in the required details.", "How can I sell a motorcycle on the platform?" },
                    { 321, "يمكنك عرض موتوسيكلك للبيع من خلال التطبيق وملء البيانات المطلوبة.", "كيف يمكنني بيع موتوسيكل على المنصة؟" },
                    { 322, "نعم، لدينا سيارات كهربائية جديدة يمكنك شراءها عبر المنصة.", "هل يوجد سيارات كهربائية جديدة للبيع؟" },
                    { 323, "Yes, we have new electric cars available for purchase on the platform.", "Are there new electric cars for sale?" },
                    { 324, "نعم، لدينا سيارات كهربائية جديدة يمكنك شراءها عبر المنصة.", "هل يوجد سيارات كهربائية جديدة للبيع؟" },
                    { 325, "نعم، يمكنك شراء سيارات كهربائية مستعملة من خلال المنصة.", "هل يمكنني شراء سيارة كهربائية مستعملة؟" },
                    { 326, "Yes, you can buy used electric cars through the platform.", "Can I buy a used electric car?" },
                    { 327, "نعم، يمكنك شراء سيارات كهربائية مستعملة من خلال المنصة.", "هل يمكنني شراء سيارة كهربائية مستعملة؟" },
                    { 328, "يمكنك عرض سيارتك الكهربائية للبيع من خلال التطبيق وملء التفاصيل المطلوبة.", "كيف أقدر أبيع سيارة كهربائية على المنصة؟" },
                    { 329, "You can list your electric car for sale through the app and fill in the required details.", "How can I sell an electric car on the platform?" },
                    { 330, "يمكنك عرض سيارتك الكهربائية للبيع من خلال التطبيق وملء التفاصيل المطلوبة.", "كيف يمكنني بيع سيارة كهربائية على المنصة؟" },
                    { 331, "نعم، نقدم خدمات صيانة للموتوسيكلات الجديدة والمستعملة.", "هل يوجد خدمة صيانة للموتوسيكلات على المنصة؟" },
                    { 332, "Yes, we offer maintenance services for both new and used motorcycles.", "Is there maintenance service for motorcycles on the platform?" },
                    { 333, "نعم، نقدم خدمات صيانة للموتوسيكلات الجديدة والمستعملة.", "هل توجد خدمة صيانة للموتوسيكلات على المنصة؟" },
                    { 334, "نعم، لدينا قطع غيار متوفرة للموتوسيكلات الكهربائية على المنصة.", "هل يوجد قطع غيار للموتوسيكلات الكهربائية؟" },
                    { 335, "Yes, we have spare parts available for electric motorcycles on the platform.", "Are there spare parts for electric motorcycles?" },
                    { 336, "نعم، لدينا قطع غيار متوفرة للموتوسيكلات الكهربائية على المنصة.", "هل توجد قطع غيار للموتوسيكلات الكهربائية؟" },
                    { 337, "نعم، نحن نقدم خدمات صيانة للسيارات الكهربائية عبر المنصة.", "هل يمكنني صيانة السيارة الكهربائية من خلال المنصة؟" },
                    { 338, "Yes, we offer maintenance services for electric cars through the platform.", "Can I service my electric car through the platform?" },
                    { 339, "نعم، نحن نقدم خدمات صيانة للسيارات الكهربائية عبر المنصة.", "هل يمكنني صيانة السيارة الكهربائية من خلال المنصة؟" },
                    { 340, "نعم، يمكنك شراء سيارات كهربائية مستعملة من خلال المنصة.", "هل يمكنني شراء سيارة كهربائية مستعملة عبر المنصة؟" },
                    { 341, "Yes, you can buy a used electric car through the platform.", "Can I buy a used electric car through the platform?" },
                    { 342, "نعم، يمكنك شراء سيارات كهربائية مستعملة من خلال المنصة.", "هل يمكنني شراء سيارة كهربائية مستعملة عبر المنصة؟" },
                    { 343, "يمكنك عرض سيارتك الكهربائية المستعملة للبيع من خلال التطبيق وملء التفاصيل المطلوبة.", "كيف يمكنني بيع سيارة كهربائية مستعملة؟" },
                    { 344, "You can list your used electric car for sale through the app and fill in the required details.", "How can I sell a used electric car?" },
                    { 345, "يمكنك عرض سيارتك الكهربائية المستعملة للبيع من خلال التطبيق وملء التفاصيل المطلوبة.", "كيف يمكنني بيع سيارة كهربائية مستعملة؟" },
                    { 346, "نعم، نقدم خدمة شحن السيارات الكهربائية في أماكن معينة.", "هل تقدمون خدمة شحن للسيارات الكهربائية؟" },
                    { 347, "Yes, we offer charging services for electric cars at certain locations.", "Do you offer charging service for electric cars?" },
                    { 348, "نعم، نقدم خدمة شحن السيارات الكهربائية في أماكن معينة.", "هل تقدمون خدمة شحن للسيارات الكهربائية؟" },
                    { 349, "يمكنك التقدم لوظيفة فني صيانة من خلال قسم الوظائف في التطبيق أو الموقع.", "إزاي أقدر أتقدم لوظيفة فني صيانة؟" },
                    { 350, "You can apply for a maintenance technician job through the jobs section in the app or website.", "How can I apply for a maintenance technician job?" },
                    { 351, "يمكنك التقديم لوظيفة فني صيانة من خلال قسم الوظائف في التطبيق أو الموقع.", "كيف أستطيع التقدم لوظيفة فني صيانة؟" },
                    { 352, "نعم، هناك العديد من فرص العمل المتاحة لوظائف فني صيانة، يمكنك التقديم من خلال الموقع.", "هل في فرص لوظائف فني صيانة؟" },
                    { 353, "Yes, there are many job opportunities available for maintenance technician positions. You can apply through the website.", "Are there opportunities for maintenance technician jobs?" },
                    { 354, "نعم، هناك العديد من الفرص المتاحة لوظائف فني صيانة، يمكنك التقديم من خلال الموقع.", "هل توجد فرص لوظائف فني صيانة؟" },
                    { 355, "نعم، لدينا وظائف شاغرة في مجالات تطوير التطبيقات والمواقع الإلكترونية، يمكنك التقديم من خلال قسم الوظائف.", "هل في وظائف في مجال تطوير التقنية؟" },
                    { 356, "Yes, we have job openings in app and website development. You can apply through the jobs section.", "Are there technology development jobs available?" },
                    { 357, "نعم، لدينا وظائف شاغرة في مجالات تطوير التطبيقات والمواقع الإلكترونية، يمكنك التقديم من خلال قسم الوظائف.", "هل توجد وظائف في مجال تطوير التقنية؟" },
                    { 358, "يمكنك التقدم لوظيفة مطور ويب من خلال قسم الوظائف على المنصة.", "كيف أقدر أتقدم لوظيفة مطور ويب؟" },
                    { 359, "You can apply for a web developer job through the jobs section on the platform.", "How can I apply for a web developer job?" },
                    { 360, "يمكنك التقدم لوظيفة مطور ويب من خلال قسم الوظائف على المنصة.", "كيف يمكنني التقدم لوظيفة مطور ويب؟" },
                    { 361, "نعم، نبحث دائمًا عن مطوري تطبيقات مبتكرين للانضمام لفريق العمل.", "هل في فرص لوظائف مطوري تطبيقات؟" },
                    { 362, "Yes, we are always looking for innovative app developers to join the team.", "Are there opportunities for app developer jobs?" },
                    { 363, "نعم، نبحث دائمًا عن مطوري تطبيقات مبتكرين للانضمام لفريق العمل.", "هل توجد فرص لوظائف مطوري تطبيقات؟" },
                    { 364, "نعم، يمكنك التقديم لوظيفة مهندس برمجيات من خلال قسم الوظائف المتاحة على المنصة.", "هل أقدر أقدم لوظيفة مهندس برمجيات؟" },
                    { 365, "Yes, you can apply for a software engineer job through the available job section on the platform.", "Can I apply for a software engineer job?" },
                    { 366, "نعم، يمكنك التقديم لوظيفة مهندس برمجيات من خلال قسم الوظائف المتاحة على المنصة.", "هل يمكنني التقديم لوظيفة مهندس برمجيات؟" },
                    { 367, "نعم، هناك فرص لوظائف فنيين صيانة مختصين في السيارات الكهربائية. يمكنك التقديم عبر قسم الوظائف.", "هل في وظائف فني صيانة خاصة بالسيارات الكهربائية؟" },
                    { 368, "Yes, there are opportunities for electric car maintenance technicians. You can apply through the jobs section.", "Are there jobs for electric car maintenance technicians?" },
                    { 369, "نعم، هناك فرص لوظائف فنيين صيانة مختصين في السيارات الكهربائية. يمكنك التقديم عبر قسم الوظائف.", "هل توجد وظائف فني صيانة مختص في السيارات الكهربائية؟" },
                    { 370, "لتكون فني صيانة للسيارات الكهربائية، يمكنك التقديم لوظائف التدريب المتاحة لدينا.", "إزاي أقدر أكون فني صيانة سيارات كهربائية؟" },
                    { 371, "To become an electric car maintenance technician, you can apply for available training jobs with us.", "How can I become an electric car maintenance technician?" },
                    { 372, "لتكون فني صيانة للسيارات الكهربائية، يمكنك التقديم لوظائف التدريب المتاحة لدينا.", "كيف يمكنني أن أكون فني صيانة سيارات كهربائية؟" },
                    { 373, "نعم، لدينا وظائف خاصة بتطوير التطبيقات المرتبطة بخدمات السيارات. يمكنك التقديم من خلال قسم الوظائف.", "هل يوجد وظائف تقنية متخصصة في تطوير تطبيقات السيارات؟" },
                    { 374, "Yes, we have jobs related to the development of apps for car services. You can apply through the jobs section.", "Are there specialized tech jobs in car app development?" },
                    { 375, "نعم، لدينا وظائف خاصة بتطوير التطبيقات المرتبطة بخدمات السيارات. يمكنك التقديم من خلال قسم الوظائف.", "هل توجد وظائف تقنية متخصصة في تطوير تطبيقات السيارات؟" },
                    { 376, "نعم، هناك وظائف لفنيين متخصصين في الأنظمة التقنية للسيارات مثل أنظمة التوجيه والمراقبة.", "هل في وظائف لفنيين مختصين في الأنظمة التقنية للسيارات؟" },
                    { 377, "Yes, there are jobs for technicians specialized in car tech systems such as steering and monitoring systems.", "Are there jobs for technicians specialized in car tech systems?" },
                    { 378, "نعم، هناك وظائف لفنيين متخصصين في الأنظمة التقنية للسيارات مثل أنظمة التوجيه والمراقبة.", "هل توجد وظائف لفنيين مختصين في الأنظمة التقنية للسيارات؟" },
                    { 379, "نعم، هناك العديد من الفرص المتاحة لفنيي صيانة السيارات الكهربائية. يمكنكم التقديم من خلال المنصة.", "هل في وظائف لفني صيانة السيارات الكهربائية؟" },
                    { 380, "Yes, there are many opportunities for electric car maintenance technicians. You can apply through the platform.", "Are there jobs for electric car maintenance technicians?" },
                    { 381, "نعم، هناك العديد من الفرص المتاحة لفنيي صيانة السيارات الكهربائية. يمكنكم التقديم من خلال المنصة.", "هل توجد وظائف لفني صيانة السيارات الكهربائية؟" },
                    { 382, "نعم، يمكنك التقديم لوظيفة مطور تطبيقات من خلال قسم الوظائف المتاحة في المنصة.", "هل يمكنني التقديم لوظيفة مطور تطبيقات؟" },
                    { 383, "Yes, you can apply for an app developer job through the available jobs section on the platform.", "Can I apply for an app developer job?" },
                    { 384, "نعم، يمكنك التقديم لوظيفة مطور تطبيقات من خلال قسم الوظائف المتاحة في المنصة.", "هل يمكنني التقديم لوظيفة مطور تطبيقات؟" },
                    { 385, "نعم، هناك العديد من الوظائف المتاحة في تطوير المواقع. يمكنك التقديم من خلال المنصة.", "هل هناك وظائف في تطوير المواقع؟" },
                    { 386, "Yes, there are many jobs available in website development. You can apply through the platform.", "Are there jobs available in website development?" },
                    { 387, "نعم، هناك العديد من الوظائف المتاحة في تطوير المواقع. يمكنك التقديم من خلال المنصة.", "هل توجد وظائف في تطوير المواقع؟" },
                    { 388, "يمكنك شراء سيارة من خلال تصفح العروض المتاحة في قسم بيع السيارات واختيار الأنسب لك.", "كيف يمكنني شراء سيارة عبر المنصة؟" },
                    { 389, "You can buy a car by browsing the available listings in the car sales section and choosing the one that suits you.", "How can I buy a car through the platform?" },
                    { 390, "يمكنك شراء سيارة من خلال تصفح العروض المتاحة في قسم بيع السيارات واختيار الأنسب لك.", "كيف أستطيع شراء سيارة عبر المنصة؟" },
                    { 391, "نعم، يمكنك بيع سيارتك من خلال إضافة عرض بيع للسيارة في قسم بيع السيارات.", "هل يمكنني بيع سيارتي عبر المنصة؟" },
                    { 392, "Yes, you can sell your car by adding a car listing in the car sales section.", "Can I sell my car through the platform?" },
                    { 393, "نعم، يمكنك بيع سيارتك من خلال إضافة عرض بيع للسيارة في قسم بيع السيارات.", "هل أستطيع بيع سيارتي عبر المنصة؟" },
                    { 394, "نعم، يمكنك العثور على عروض بيع موتوسيكلات جديدة ومستعملة على المنصة.", "هل المنصة تبيع موتوسيكلات؟" },
                    { 395, "Yes, you can find listings for new and used motorcycles on the platform.", "Does the platform sell motorcycles?" },
                    { 396, "نعم، يمكنك العثور على عروض بيع موتوسيكلات جديدة ومستعملة على المنصة.", "هل توجد عروض لبيع موتوسيكلات على المنصة؟" },
                    { 397, "نعم، يمكنك بيع موتوسيكل من خلال إضافة عرض في قسم بيع الموتوسيكلات.", "هل يمكنني بيع موتوسيكل عبر المنصة؟" },
                    { 398, "Yes, you can sell a motorcycle by adding a listing in the motorcycle sales section.", "Can I sell a motorcycle through the platform?" },
                    { 399, "نعم، يمكنك بيع موتوسيكل من خلال إضافة عرض في قسم بيع الموتوسيكلات.", "هل أستطيع بيع موتوسيكل عبر المنصة؟" },
                    { 400, "نعم، يمكنك العثور على سيارات كهربائية جديدة ومستعملة عبر المنصة.", "هل المنصة تبيع سيارات كهربائية؟" },
                    { 401, "Yes, you can find new and used electric cars on the platform.", "Does the platform sell electric cars?" },
                    { 402, "نعم، يمكنك العثور على سيارات كهربائية جديدة ومستعملة عبر المنصة.", "هل توجد سيارات كهربائية للبيع على المنصة؟" },
                    { 403, "يمكنك شراء سيارة كهربائية من خلال تصفح العروض المتاحة في قسم بيع السيارات الكهربائية.", "كيف يمكنني شراء سيارة كهربائية؟" },
                    { 404, "You can buy an electric car by browsing the listings in the electric car sales section.", "How can I buy an electric car?" },
                    { 405, "يمكنك شراء سيارة كهربائية من خلال تصفح العروض المتاحة في قسم بيع السيارات الكهربائية.", "كيف أستطيع شراء سيارة كهربائية؟" },
                    { 406, "نعم، لدينا وظائف متاحة في مجالات تطوير البرمجيات، الشبكات، وتصميم الواجهات.", "هل في وظائف أخرى في مجال التقنية؟" },
                    { 407, "Yes, we have openings in software development, networking, and UI/UX design.", "Are there other jobs in the tech field?" },
                    { 408, "نعم، لدينا وظائف متاحة في مجالات تطوير البرمجيات، الشبكات، وتصميم الواجهات.", "هل توجد وظائف أخرى في مجال التقنية؟" },
                    { 409, "يمكنك التقديم من خلال قسم الوظائف في المنصة واختيار الوظيفة التي تناسب مهاراتك.", "كيف أقدر أتقدم لوظيفة في مجال التقنية؟" },
                    { 410, "You can apply through the jobs section on the platform and choose the job that fits your skills.", "How can I apply for a tech job?" },
                    { 411, "يمكنك التقديم من خلال قسم الوظائف في المنصة واختيار الوظيفة التي تناسب مهاراتك.", "كيف يمكنني التقدم لوظيفة في مجال التقنية؟" },
                    { 412, "يمكنك حجز خدمة غسيل السيارات من خلال التطبيق أو الموقع واختيار الخدمة المناسبة لك.", "كيف يمكنني حجز خدمة غسيل سيارات؟" },
                    { 413, "You can book a car washing service through the app or website and select the service that suits you.", "How can I book a car washing service?" },
                    { 414, "يمكنك حجز خدمة غسيل السيارات من خلال التطبيق أو الموقع واختيار الخدمة المناسبة لك.", "كيف أستطيع حجز خدمة غسيل سيارات؟" },
                    { 415, "نعم، يمكنك تخصيص خدمة غسيل السيارة وفقًا لاحتياجاتك، مثل إضافة تنظيف داخلي أو تنظيف العجلات.", "هل يمكنني تخصيص خدمة غسيل السيارة؟" },
                    { 416, "Yes, you can customize your car washing service according to your needs, such as adding interior cleaning or wheel cleaning.", "Can I customize my car washing service?" },
                    { 417, "نعم، يمكنك تخصيص خدمة غسيل السيارة وفقًا لاحتياجاتك، مثل إضافة تنظيف داخلي أو تنظيف العجلات.", "هل يمكنني تخصيص خدمة غسيل السيارة؟" },
                    { 418, "يمكنك طلب خدمة التوصيل من خلال تطبيقنا أو الموقع، فقط اختر المكان والوقت المناسب لك.", "كيف يمكنني طلب خدمة توصيل؟" },
                    { 419, "You can request a delivery service through our app or website by selecting the location and time that suits you.", "How can I request a delivery service?" },
                    { 420, "يمكنك طلب خدمة التوصيل من خلال تطبيقنا أو الموقع، فقط اختر المكان والوقت المناسب لك.", "كيف أستطيع طلب خدمة توصيل؟" },
                    { 421, "نعم، خدمة التوصيل متاحة في العديد من المناطق. يمكنك التحقق من توفر الخدمة في منطقتك عبر التطبيق.", "هل خدمة التوصيل متاحة في جميع المناطق؟" },
                    { 422, "Yes, the delivery service is available in many areas. You can check the availability in your area through the app.", "Is the delivery service available in all areas?" },
                    { 423, "نعم، خدمة التوصيل متاحة في العديد من المناطق. يمكنك التحقق من توفر الخدمة في منطقتك عبر التطبيق.", "هل خدمة التوصيل متاحة في كل المناطق؟" },
                    { 424, "يمكنك شراء قطع الغيار من خلال قسم بيع قطع الغيار في التطبيق أو الموقع.", "كيف أقدر أشتري قطع غيار؟" },
                    { 425, "You can buy spare parts through the spare parts section on the app or website.", "How can I buy spare parts?" },
                    { 426, "يمكنك شراء قطع الغيار من خلال قسم بيع قطع الغيار في التطبيق أو الموقع.", "كيف أستطيع شراء قطع غيار؟" },
                    { 427, "نعم، يمكنك شراء قطع غيار للسيارات الكهربائية من قسم قطع الغيار المتاح على المنصة.", "هل يمكنني شراء قطع غيار للسيارات الكهربائية؟" },
                    { 428, "Yes, you can buy spare parts for electric cars from the spare parts section available on the platform.", "Can I buy spare parts for electric cars?" },
                    { 429, "نعم، يمكنك شراء قطع غيار للسيارات الكهربائية من قسم قطع الغيار المتاح على المنصة.", "هل توجد قطع غيار للسيارات الكهربائية؟" },
                    { 430, "نعم، يمكنك بيع سيارتك المستعملة من خلال إضافة عرض للبيع في قسم السيارات المستعملة.", "هل يمكنني بيع سيارتي المستعملة عبر المنصة؟" },
                    { 431, "Yes, you can sell your used car by adding a listing in the used car section.", "Can I sell my used car through the platform?" },
                    { 432, "نعم، يمكنك بيع سيارتك المستعملة من خلال إضافة عرض للبيع في قسم السيارات المستعملة.", "هل أستطيع بيع سيارتي المستعملة عبر المنصة؟" },
                    { 433, "نعم، لدينا سيارات كهربائية مستعملة للبيع، يمكنك الاطلاع على العروض المتاحة.", "هل يوجد سيارات كهربائية مستعملة للبيع؟" },
                    { 434, "Yes, we have used electric cars for sale. You can check the available listings.", "Are there used electric cars for sale?" },
                    { 435, "نعم، لدينا سيارات كهربائية مستعملة للبيع، يمكنك الاطلاع على العروض المتاحة.", "هل توجد سيارات كهربائية مستعملة للبيع؟" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 1, "Sedan", "black", "New", null, "E200 2025 \r\nAmg Premium Plus\r\nsoft close\r\nkeyless entry\r\nkeyless start\r\nelectric seats\r\nmemory seats\r\nheated seats\r\nheadup display\r\nfourzone ac\r\ncamera 360\r\nblind spot\r\nnight package\r\nblack rims\r\nfor more info call us at (View phone number)\r\nor visit us at 53 Abbas el Akkad", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "E200", "2000 CC", "Mercedes-Benz", "Mercedes", 5550000m, 5, "Car", "2025" },
                    { 2, "Sedan", "Gray", "New", null, "MERCEDES MAYBACH S-560 4MATIC 2024\r\n\r\nبأقل سعر فى مصر\r\nاسعارخاصه للعملاء الكاش\r\nمتاح انظمه تقسيط بدون حظر بيع و بدون م اداريه و بدون تأمين\r\nعروض خاصه و حصريه لرجال الاعمال بسجل تجارى و بطاقه ضريبيه تحصل على مقدم يبدأ من 5% و تقسيط لمده 10 سنوات\r\n\r\nمتاح استبدال سيارتك القديمه\r\nمتاح ايضا لدينا اكثر من 30 برنامج للتقسيط ل ربات البيوت والموظفين و الاطباء والظباط\r\n\r\n Available all colors, Models and Categories \r\nالاسعار تختلف حسب الفئه و الموديل\r\n   ", null, "Automatic", "/Images/Teacher Motors.WEBP", "Teacher Motors", "0114585330", "S-580", "4000 CC", "MERCEDES MAYBACH", "Mercedes", 24000000m, 5, "Car", "2024" },
                    { 3, "Sedan", "White", "New", null, "Toyota corolla \r\nModel 2025\r\nالفئة الثالثة\r\nor visit us at 53 Abbas El Akkad, Nasr city", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Corolla", "1600 CC", "Toyota Corolla 2025", "Toyota", 1600000m, 5, "Car", "2025" },
                    { 4, "Coupe", "White", "New", null, "Glc 300 \r\nModel 2025\r\nhydraulic suspension\r\nrear axle\r\nHeadup display\r\nfourzone\r\ncamera360\r\nburmester speakers \r\nblind spot\r\nelectric seats\r\nmemory seats\r\nheater seats\r\nkeyless entry\r\nside doorstep\r\nfeather rims", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "GLC 300", "2000 CC", "Mercedes-Benz GLC 300", "Mercedes", 6250000m, 5, "Car", "2025" },
                    { 5, "Sedan", "black", "New", null, "E200 \r\nmodel 2024 \r\nzero\r\nfully loaded \r\nnight package", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "E200", "2000 CC", "Mercedes Benz E200", "Mercedes", 5375000m, 5, "Car", "2024" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BatteryCapacity", "ElectricCars_CarType", "ChargingTime", "Color", "Condition", "Description", "ElectricCars_Discount", "ElectricCars_Gearbox_Type", "Interior", "Model", "Name", "Power", "Prand", "Price", "ElectricCars_Rate", "TravelRange", "VehicleType", "Year" },
                values: new object[] { 6, null, "SUV", null, "black", "New", "Id6 crozz pro 2024 \r\nEnergy type: Pure electric \r\nRange: 601\r\nMax speed: 160\r\nCamera 360\r\nBlind spot\r\nHeadup display", null, "Automatic", null, "ID6 Crozz Pro", "Volkswagen ID6 Crozz Pro", null, "Volkswagen", 2350000m, 5, 601, "ElectricCar", "2024" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType", "Color", "Condition", "Description", "FuelType", "Gearbox_Type", "KilometersDriven", "Model", "Motor_Capacity", "Name", "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber", "Prand", "Price", "UsedCondition", "VehicleType", "Year" },
                values: new object[] { 7, "Coupe", "black", "Used", "Available now at 4Matic\r\nPorsche Taycan \r\nModel 2024\r\n4000 Km\r\nLicensed\r\nhas Protection \r\nRange 400-500", "Electric", "Autohmatic", 4000, "Taycan", null, "Porsche Taycan 2024", null, null, null, null, null, "Porsche", 6150000m, "Like New", "UsedCar", "2024" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[] { 8, "Sedan", "black", "New", null, "Range Rover Velar R-daynamic\r\n- Model 2025\r\n- ⁠Zero\r\n- فيها رخصه ٣ سنين\r\n- ⁠10 years warranty Protection\r\n- Engine : 2.0 liter\r\n- 250 HP\r\n- ⁠Exterior Color : Black \r\n- Interior Color : Beig leather\r\n- Apple Carplay & Android Auto\r\n- Slide Panoramic Sunroof\r\n- Meredian Sound system\r\n- Blind spot\r\n- Lane assist\r\n- Adaptive Control\r\n- 2 electric seats with memory \r\n- Head up Display\r\n- Air suspention\r\n- Ambient light system\r\n- electric trunk\r\n- Keyless Go\r\n- Front and rear sensor park\r\n- 360 camera\r\n- Heated seats\r\n- Automatic AC control\r\n- 20 inch Black allow wheel", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Velar", "2000 CC", "Range Rover Velar 2025", "Land Rover", 6350000m, 5, "Car", "2025" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType", "Color", "Condition", "Description", "FuelType", "Gearbox_Type", "KilometersDriven", "Model", "Motor_Capacity", "Name", "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber", "Prand", "Price", "UsedCondition", "VehicleType", "Year" },
                values: new object[] { 9, "SUV", "White", "Used", "6500 km\r\nprotection\r\nlicensed\r\nlaurent & klement\r\ncamera 360\r\nالعنوان ٥٣ شارع عباس العقاد", "Benzine", "Autohmatic", 6500, "Taycan", null, "Skoda Kodiaq 2024 Laurin & Klement", null, null, null, null, null, "Skoda", 2850000m, "Like New", "UsedCar", "2024" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 10, "Sedan", "black", "New", null, "Porsche Macan\r\nبورش ماكان\r\n\r\nModel 2024 (wakeel)\r\nموديل 2024 (وكيل)\r\n\r\nPre owned 17,000KM\r\nمستعملة بممشى 17,000 كم\r\n\r\nExterior: Metallic Black\r\nاللون الخارجي: أسود ميتاليك\r\n\r\nInterior: Red leather\r\nاللون الداخلي: جلد أحمر\r\n\r\nEngine type: turbocharged\r\nنوع المحرك: تيربو\r\n\r\n2L straight 4 cylinders\r\n2 لتر، 4 سلندر خطي\r\n\r\nHorsepower: 261 hp\r\nقوة المحرك: 261 حصان\r\n\r\nMax. torque 295 lb-ft\r\nأقصى عزم: 295 رطل/قدم\r\n\r\n0 - 60 mph in 5.8 seconds with Sport Chrono Package\r\nمن 0 إلى 60 ميل في الساعة في 5.8 ثانية مع باكيدج سبورت كرونو\r\n\r\nTransmission: 7-speed twin-clutch auto (PDK)\r\nناقل حركة أوتوماتيك 7 سرعات (PDK) ثنائي القابض\r\n\r\nAll wheel drive\r\nدفع كلي\r\n\r\nPanoramic sunroof\r\nفتحة سقف بانورامية\r\n\r\nRims: R20 multi spoke\r\nجنوط R20 متعددة الأذرع\r\n\r\n360 parking cameras\r\nكاميرات ركن 360 درجة\r\n\r\nBoss sound system\r\nنظام صوتي من Bose\r\n\r\nThe LED headlights including Porsche Dynamic Light System (PDLS)\r\nكشافات LED تشمل نظام الإضاءة الديناميكي من بورش (PDLS)\r\n\r\nKeyless entry and start/stop\r\nدخول وتشغيل بدون مفتاح\r\n\r\n8-way Front Sport Seats\r\nمقاعد أمامية رياضية بـ 8 وضعيات\r\n\r\nSeat heating\r\nتدفئة للمقاعد\r\n\r\nPorsche logo on seats\r\nشعار بورش على المقاعد\r\n\r\nPorsche word illuminate as welcome\r\nإضاءة كلمة Porsche عند الترحيب\r\n\r\nElectric tailgate\r\nباب شنطة خلفية كهربائي\r\n\r\nApple CarPlay\r\nابل كار بلاي\r\n\r\nAndroid Auto\r\nأندرويد أوتو\r\n\r\nWireless phone charger\r\nشاحن لاسلكي للهاتف\r\n\r\nNavigation system\r\nنظام ملاحة\r\n\r\nSport space tires\r\nكفرات سبور سبيس\r\n\r\nPrivacy glass\r\nزجاج فاميـه (خصوصي)\r\n\r\nLarge brake system with black paint callipers\r\nنظام فرامل كبير مع كاليبرات باللون الأسود\r\n\r\nElectronic brake distribution\r\nتوزيع إلكتروني لقوة الفرامل", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Macan", "2000 CC", "Porsche Macan 2024", "Porsche", 4850000m, 5, "Car", "2024" },
                    { 11, "Sedan", "White", "New", null, "هونداي الينترا cn7 اعلى فئة  ٢٠٢٥ متوفرة الان في اكسدرايف اوتوموتيف\r\n\r\n\r\n\r\nالمواصفات : بصمة داخليه خارجيه ، فتحة سقف ، عدادات ديجتال ، فرش جلد ، تحديد مسار ، تسخين كراسي ، تسخين مقود ، جنوط ١٧ لونين ، مرايات ضم ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش ، سينسور بارك امامي خلفي \r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة\r\n\r\n لمزيد من التفاصيل يرجى التواصل على الارقام التالية", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Elantra", "1500 CC", "Hyundai Elantra 2025", "Hyundai", 1550000m, 5, "Car", "2025" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType", "Color", "Condition", "Description", "FuelType", "Gearbox_Type", "KilometersDriven", "Model", "Motor_Capacity", "Name", "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber", "Prand", "Price", "UsedCondition", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 12, "SUV", null, "Used", "السيارة الكهربائية بالكامل كيا Ev5 موديل ٢٠٢٤  متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : محرك كهربائي يولد 215 حصان ، فتحة سقف بانورامية ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة", "Benzine", "Autohmatic", 15449, "EV5", null, "Kia EV5 2024", null, null, null, null, null, "Kia", 1690000m, "Like New", "UsedCar", "2024" },
                    { 13, "SUV", null, "Used", "\r\nرانج روفر ايفوك ٢٠٢١ SE عداد ٨ الف كيلو متوفرة الان في اكسدرايف اوتوموتيف\r\n\r\nالمواصفات : ١٥٠٠ سي سي توربو ١٦٠ حصان ، ليد داخلي متعدد الألوانة ، كاميرا ٣٦٠ درجة ، بصمة داخليه خارجيه ، كرسي كهرباء ، عدادات ديجتال ، مرايات ضم ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش ، سينسور بارك امامي خلفي \r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة", "Benzine", "Autohmatic", 7000, "Evoque", null, "RANGE ROVE EVOQUE 2021", null, null, null, null, null, "Land Rover", 3150000m, "Like New", "UsedCar", "2021" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 14, "SUV", "Gray", "New", null, "هونداي الينتراMG RX5 2024 Luxury  متوفرة الان في اكسدرايف اوتوموتيف \r\n\r\n\r\n\r\nالمواصفات : ١. ٥٠٠ سي سي توربو ، بصمة داخليه خارجيه ، فتحة سقف بانوراما ، تكييف ديجتال ، فرش جلد، جنوط١٨ ، مرايات ضم ، شاحن وايرلس ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش تدعم apple carplay و android auto ، سينسور بارك امامي خلفي ، كاميرات محيطية ٣٦٠ درجة\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "RX5", "1500 CC", "MG RX5 2024", "MG", 1450000m, 5, "Car", "2024" },
                    { 15, "SUV", null, "New", null, "هونداي الينتراالسيارة الكهربائية بالكامل اودي Q4 e-tron موديل 2024 متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : 40e-tron ، محرك كهربائي يولد ٢٣٠ حصان ، ٧ راكب ، فتحة سقف بانورامية متحركة ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، شاشة عرض على الزجاج الامامي HUD ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Q4 E-Tron", "1500 CC", "Audi Q4 E-Tron 2024", "Audi", 2390000m, 5, "Car", "2024" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BatteryCapacity", "ElectricCars_CarType", "ChargingTime", "Color", "Condition", "Description", "ElectricCars_Discount", "ElectricCars_Gearbox_Type", "Interior", "Model", "Name", "Power", "Prand", "Price", "ElectricCars_Rate", "TravelRange", "VehicleType", "Year" },
                values: new object[] { 16, null, "SUV", null, "White", "New", "السيارة الكهربائية بالكامل شانجان S7 موديل ٢٠٢٤  متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : محرك كهربائي يولد ٢٥٨ حصان ، فتحة سقف بانورامية ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، شاشة عرض على الزجاج الامامي HUD ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة\r\n", null, "Automatic", "Full Leather", "V7", "Changan S7 FULL ELECTRIC 2024", 258, "Changan", 1950000m, 5, null, "ElectricCar", "2024" });

            migrationBuilder.InsertData(
                table: "CarModel",
                columns: new[] { "Id", "BrandId", "Name", "NameAR" },
                values: new object[,]
                {
                    { 1, 1, "Corolla", "كورولا" },
                    { 2, 1, "Camry", "كامري" },
                    { 3, 1, "Land Cruiser", "لاند كروزر" },
                    { 4, 1, "Hilux", "هايلوكس" },
                    { 5, 1, "Yaris", "ياريس" },
                    { 6, 1, "Fortuner", "فورتشنر" },
                    { 7, 1, "Highlander", "هايلاندر" },
                    { 8, 2, "Verna", "فيرنا" },
                    { 9, 2, "Excel", "اكسل" },
                    { 10, 2, "Elantra", "النترا" },
                    { 11, 2, "Tucson", "توسان" },
                    { 12, 2, "Sonata", "سوناتا" },
                    { 13, 2, "Palisade", "باليسيد" },
                    { 14, 2, "Accent", "اكسنت" },
                    { 15, 2, "Kona", "كونا" },
                    { 16, 2, "Ioniq", "ايونيك" },
                    { 17, 3, "Altima", "ألتيما" },
                    { 18, 3, "Maxima", "ماكسيما" },
                    { 19, 3, "Patrol", "باترول" },
                    { 20, 3, "Sentra", "سينترا" },
                    { 21, 3, "X-Trail", "إكس تريل" },
                    { 22, 3, "Juke", "جوك" },
                    { 23, 3, "Rogue", "روج" },
                    { 24, 4, "Sportage", "سبورتاج" },
                    { 25, 4, "Cerato", "سيراتو" },
                    { 26, 4, "Optima", "أوبتيما" },
                    { 27, 4, "Seltos", "سيلتوس" },
                    { 28, 4, "Stinger", "ستينجر" },
                    { 29, 4, "Picanto", "بيكانتو" },
                    { 30, 5, "Optra", "أوبترا" },
                    { 31, 5, "Aveo", "أفيو" },
                    { 32, 5, "Malibu", "ماليبو" },
                    { 33, 5, "Cruze", "كروز" },
                    { 34, 5, "Tahoe", "تاهو" },
                    { 35, 6, "C-Class", "سي كلاس" },
                    { 36, 6, "E-Class", "إي كلاس" },
                    { 37, 6, "S-Class", "إس كلاس" },
                    { 38, 6, "GLE", "جي إل إي" },
                    { 39, 6, "GLC", "جي إل سي" },
                    { 40, 7, "X5", "اكس 5" },
                    { 41, 7, "3 Series", "السلسلة 3" },
                    { 42, 7, "7 Series", "السلسلة 7" },
                    { 43, 7, "X3", "اكس 3" },
                    { 44, 7, "M4", "إم 4" },
                    { 45, 8, "Civic", "سيفيك" },
                    { 46, 8, "Accord", "أكورد" },
                    { 47, 8, "CR-V", "سي آر في" },
                    { 48, 8, "Pilot", "بايلوت" },
                    { 49, 8, "HR-V", "إتش آر في" },
                    { 50, 8, "Jazz", "جاز" },
                    { 51, 8, "Odyssey", "أوديسي" },
                    { 52, 9, "Mustang", "موستنج" },
                    { 53, 9, "F-150", "إف 150" },
                    { 54, 9, "Explorer", "إكسبلورر" },
                    { 55, 9, "Escape", "إسكاب" },
                    { 56, 10, "Cherokee", "شيروكاي" },
                    { 57, 10, "Wrangler", "رانجلر" },
                    { 58, 10, "Grand Cherokee", "جراند شيروكي" },
                    { 59, 11, "A3", "A3" },
                    { 60, 11, "A4", "A4" },
                    { 61, 11, "Q7", "Q7" },
                    { 62, 11, "Q5", "Q5" },
                    { 63, 11, "A6", "A6" },
                    { 64, 11, "Q8", "Q8" },
                    { 65, 11, "RS7", "RS7" },
                    { 66, 12, "Mazda 3", "مازدا 3" },
                    { 67, 12, "Mazda 6", "مازدا 6" },
                    { 68, 12, "CX-5", "CX-5" },
                    { 69, 12, "CX-9", "CX-9" },
                    { 70, 12, "MX-5 Miata", "MX-5 مياتا" },
                    { 71, 13, "Defender", "ديفندر" },
                    { 72, 13, "Discovery", "ديسكفري" },
                    { 73, 13, "Range Rover", "رانج روفر" },
                    { 74, 13, "Evoque", "إيفوك" },
                    { 75, 14, "911", "911" },
                    { 76, 14, "Cayenne", "كاين" },
                    { 77, 14, "Macan", "ماكان" },
                    { 78, 14, "Panamera", "باناميرا" },
                    { 79, 14, "Taycan", "تايكان" },
                    { 80, 15, "RX", "آر إكس" },
                    { 81, 15, "NX", "إن إكس" },
                    { 82, 15, "IS", "آي إس" },
                    { 83, 15, "LS", "آل إس" },
                    { 84, 15, "LC", "آل سي" },
                    { 85, 16, "F-Type", "إف-تايب" },
                    { 86, 16, "XE", "إكس إي" },
                    { 87, 16, "XF", "إكس إف" },
                    { 88, 16, "F-Pace", "إف-باس" },
                    { 89, 16, "I-Pace", "آي-باس" },
                    { 90, 17, "XC90", "إكس سي 90" },
                    { 91, 17, "XC60", "إكس سي 60" },
                    { 92, 17, "S90", "إس 90" },
                    { 93, 17, "V90", "في 90" },
                    { 94, 17, "S60", "إس 60" },
                    { 95, 18, "Outlander", "أوتلاندر" },
                    { 96, 18, "Lancer", "لانسر" },
                    { 97, 18, "Pajero", "بايجيرو" },
                    { 98, 18, "ASX", "إيه إس إكس" },
                    { 99, 18, "Montero", "مونتيرو" },
                    { 100, 19, "Outback", "أوتباك" },
                    { 101, 19, "Forester", "فورستر" },
                    { 102, 19, "Impreza", "إمبريزا" },
                    { 103, 19, "Legacy", "ليغاسي" },
                    { 104, 19, "WRX", "دبليو آر إكس" },
                    { 105, 20, "301", "٣٠١" },
                    { 106, 20, "3008", "٣٠٠٨" },
                    { 107, 20, "5008", "٥٠٠٨" },
                    { 108, 20, "508", "٥٠٨" },
                    { 109, 20, "206", "٢٠٦" },
                    { 110, 20, "207", "٢٠٧" },
                    { 111, 20, "208", "٢٠٨" },
                    { 112, 20, "307", "٣٠٧" },
                    { 113, 20, "308", "٣٠٨" },
                    { 114, 20, "RCZ", "آر سي زد" },
                    { 115, 21, "Logan", "لوجان" },
                    { 116, 21, "Sandero", "سانديرو" },
                    { 117, 21, "Stepway", "ستيب واي" },
                    { 118, 21, "Megane", "ميجان" },
                    { 119, 21, "Fluence", "فلوانس" },
                    { 120, 21, "Duster", "داستر" },
                    { 121, 21, "Koleos", "كوليوس" },
                    { 122, 21, "Captur", "كابتشر" },
                    { 123, 21, "Talisman", "تاليسمان" },
                    { 124, 21, "Clio", "كليو" },
                    { 125, 22, "Tipo", "تيبو" },
                    { 126, 22, "Punto", "بونتو" },
                    { 127, 22, "500", "٥٠٠" },
                    { 128, 22, "Bravo", "برافو" },
                    { 129, 22, "Linea", "لينيا" },
                    { 130, 22, "Doblo", "دوبلو" },
                    { 131, 22, "Palio", "باليـو" },
                    { 132, 22, "Siena", "سيينا" },
                    { 133, 22, "Uno", "أونو" },
                    { 134, 22, "124 Spider", "١٢٤ سبايدر" },
                    { 135, 23, "Astra", "أسترا" },
                    { 136, 23, "Corsa", "كورسا" },
                    { 137, 23, "Insignia", "إنسينييا" },
                    { 138, 23, "Mokka", "موكا" },
                    { 139, 23, "Grandland", "جراندلاند" },
                    { 140, 23, "Crossland", "كروس لاند" },
                    { 141, 23, "Zafira", "زافيرا" },
                    { 142, 23, "Vivaro", "فيفارو" },
                    { 143, 23, "Adam", "آدام" },
                    { 144, 23, "Meriva", "مريفا" },
                    { 145, 23, "Astra Sports Tourer", "أسترا سبورتس تورير" },
                    { 146, 25, "Ibiza", "إيبيزا" },
                    { 147, 25, "Leon", "ليون" },
                    { 148, 25, "Ateca", "أتكا" },
                    { 149, 25, "Tarraco", "تاراكو" },
                    { 150, 25, "Arona", "أرونا" },
                    { 151, 25, "Alhambra", "ألهامبرا" },
                    { 152, 25, "Toledo", "توليدو" },
                    { 153, 25, "Cupra Born", "كوبرا بورن" },
                    { 154, 26, "ZS", "زي إس" },
                    { 155, 26, "HS", "إتش إس" },
                    { 156, 26, "MG3", "إم جي ٣" },
                    { 157, 26, "MG5", "إم جي ٥" },
                    { 158, 26, "MG6", "إم جي ٦" },
                    { 159, 26, "MG Hector", "إم جي هيكتور" },
                    { 160, 26, "MG ZS EV", "إم جي زي إس إي في" },
                    { 161, 27, "Emgrand", "إمجراند" },
                    { 162, 27, "Coolray", "كولراي" },
                    { 163, 27, "Atlas", "أطلس" },
                    { 164, 27, "Binyue", "بينييو" },
                    { 165, 27, "Geely Xingyue", "جيلي شينغيو" },
                    { 166, 27, "Geely Emgrand EV", "جيلي إمجراند إي في" },
                    { 167, 28, "Tang", "تانغ" },
                    { 168, 28, "Song", "سونغ" },
                    { 169, 28, "Qin", "تشين" },
                    { 170, 28, "F3", "إف ٣" },
                    { 171, 28, "F5", "إف ٥" },
                    { 172, 28, "E6", "إي ٦" },
                    { 173, 28, "S7", "إس ٧" },
                    { 174, 28, "BYD Yuan", "بي واي دي يوان" },
                    { 175, 29, "J5", "جي ٥" },
                    { 176, 29, "S3", "إس ٣" },
                    { 177, 29, "JAC T6", "جي إيه سي تي ٦" },
                    { 178, 29, "JAC S7", "جي إيه سي إس ٧" },
                    { 179, 30, "Tiggo 2", "تيغو ٢" },
                    { 180, 30, "Tiggo 3", "تيغو ٣" },
                    { 181, 30, "Tiggo 4", "تيغو ٤" },
                    { 182, 30, "Tiggo 5", "تيغو ٥" },
                    { 183, 30, "Tiggo 7", "تيغو ٧" },
                    { 184, 30, "Tiggo 8", "تيغو ٨" },
                    { 185, 31, "X70", "إكس ٧٠" },
                    { 186, 31, "X90", "إكس ٩٠" },
                    { 187, 31, "T1", "تي ١" },
                    { 188, 31, "X95", "إكس ٩٥" },
                    { 189, 31, "S1", "إس ١" },
                    { 190, 31, "S5", "إس ٥" },
                    { 191, 32, "A516", "إيه ٥١٦" },
                    { 192, 32, "M11", "إم ١١" },
                    { 193, 32, "Speranza Tiggo", "سبيرانزا تيغو" },
                    { 194, 32, "Tiggo 3", "تيغو ٣" },
                    { 195, 32, "Tiggo 5", "تيغو ٥" },
                    { 196, 33, "X25", "إكس ٢٥" },
                    { 197, 33, "X55", "إكس ٥٥" },
                    { 198, 33, "BJ40", "بي جي ٤٠" },
                    { 199, 33, "BJ80", "بي جي ٨٠" },
                    { 200, 33, "J7", "جي ٧" },
                    { 201, 33, "J3", "جي ٣" },
                    { 202, 34, "Matiz", "ماتيز" },
                    { 203, 34, "Lanos", "لانوس" },
                    { 204, 34, "Nubira", "نوبيرا" },
                    { 205, 34, "Espero", "إسبيرو" },
                    { 206, 34, "Rezzo", "ريزو" },
                    { 207, 34, "Kalos", "كالوس" },
                    { 208, 35, "DFM", "دي إف إم" },
                    { 209, 35, "Rich", "ريتش" },
                    { 210, 35, "H30", "إتش ٣٠" },
                    { 211, 35, "DF4", "دي إف ٤" },
                    { 212, 35, "DF5", "دي إف ٥" },
                    { 213, 36, "Mini Truck", "ميني ترك" },
                    { 214, 36, "Glory", "جلوري" },
                    { 215, 36, "Fengon", "فينغون" },
                    { 216, 36, "C35", "سي ٣٥" },
                    { 217, 37, "Besturn", "بيسترن" },
                    { 218, 37, "Oley", "أولي" },
                    { 219, 37, "Jiefang", "جيفانغ" },
                    { 220, 38, "Auman", "أومان" },
                    { 221, 38, "View", "فيو" },
                    { 222, 38, "C1", "سي ١" },
                    { 223, 38, "C2", "سي ٢" },
                    { 224, 39, "X60", "إكس ٦٠" },
                    { 225, 39, "X50", "إكس ٥٠" },
                    { 226, 39, "X70", "إكس ٧٠" },
                    { 227, 40, "Saga", "ساجا" },
                    { 228, 40, "Persona", "بيرسونا" },
                    { 229, 40, "Exora", "إكسورا" },
                    { 230, 40, "Iriz", "إيريز" },
                    { 231, 40, "Preve", "بريفي" },
                    { 232, 41, "Shalaby Pickup", "شلبي بيك أب" },
                    { 233, 41, "Shalaby Truck", "شلبي شاحنة" },
                    { 234, 41, "Shalaby Van", "شلبي فان" },
                    { 235, 42, "Dayun Truck", "دايون شاحنة" },
                    { 236, 42, "Dayun Pickup", "دايون بيك أب" },
                    { 237, 42, "Dayun Van", "دايون فان" },
                    { 238, 43, "Golf", "جولف" },
                    { 239, 43, "Passat", "باسات" },
                    { 240, 43, "Polo", "بولو" },
                    { 241, 43, "Tiguan", "تيجوان" },
                    { 242, 43, "Jetta", "جيتا" },
                    { 243, 43, "Arteon", "أرتيون" },
                    { 244, 43, "Touareg", "توارغ" },
                    { 245, 43, "ID.4", "آي دي ٤" },
                    { 246, 43, "Beetle", "بيتل" },
                    { 247, 44, "Octavia", "أوكتافيا" },
                    { 248, 44, "Superb", "سوبرب" },
                    { 249, 44, "Karoq", "كاروق" },
                    { 250, 44, "Kodiaq", "كودياك" },
                    { 251, 44, "Fabia", "فابيا" },
                    { 252, 44, "Scala", "سكالا" },
                    { 253, 44, "Kamiq", "كامييك" },
                    { 254, 45, "Model S", "موديل S" },
                    { 255, 45, "Model 3", "موديل 3" },
                    { 256, 45, "Model X", "موديل X" },
                    { 257, 45, "Model Y", "موديل Y" },
                    { 258, 45, "Cybertruck", "سايبر تراك" },
                    { 259, 45, "Roadster", "رودستر" },
                    { 260, 46, "Ocean", "أوشن" },
                    { 261, 46, "PEAR", "بير" },
                    { 262, 47, "M5", "أيتو M5" },
                    { 263, 47, "M7", "أيتو M7" },
                    { 264, 48, "EX5", "إي إكس 5" },
                    { 265, 48, "W6", "دبليو 6" },
                    { 266, 48, "E5", "إي 5" },
                    { 267, 49, "U5", "يو 5" },
                    { 268, 49, "U7", "يو 7" },
                    { 269, 50, "Han EV", "هان إي في" },
                    { 270, 50, "Tang EV", "تانغ إي في" },
                    { 271, 50, "Song Plus EV", "سونغ بلس إي في" },
                    { 272, 50, "Dolphin", "دولفين" },
                    { 273, 50, "Seal", "سيل" },
                    { 274, 50, "Atto 3", "آتو 3" },
                    { 275, 50, "Qin Plus EV", "تشين بلس إي في" }
                });

            migrationBuilder.InsertData(
                table: "VehicleImages",
                columns: new[] { "Id", "DriverId", "DriverId1", "ImageUrl", "SparePartsId", "VehicleId" },
                values: new object[,]
                {
                    { 1, null, null, "/Images/Mercedes-Benz 1.WEBP", null, 1 },
                    { 2, null, null, "/Images/Mercedes-Benz 2.WEBP", null, 1 },
                    { 3, null, null, "/Images/Mercedes-Benz 3.WEBP", null, 1 },
                    { 4, null, null, "/Images/Mercedes-Benz 4.WEBP", null, 1 },
                    { 5, null, null, "/Images/Mercedes-Benz 5.WEBP", null, 1 },
                    { 6, null, null, "/Images/Mercedes-Benz 6.WEBP", null, 1 },
                    { 7, null, null, "/Images/Mercedes-Benz 7.WEBP", null, 1 },
                    { 8, null, null, "/Images/Mercedes-Benz 8.WEBP", null, 1 },
                    { 9, null, null, "/Images/Mercedes-Benz 9.WEBP", null, 1 },
                    { 10, null, null, "/Images/Mercedes-Benz 10.WEBP", null, 1 },
                    { 11, null, null, "/Images/MERCEDES MAYBACH 1.WEBP", null, 2 },
                    { 12, null, null, "/Images/MERCEDES MAYBACH 2.WEBP", null, 2 },
                    { 13, null, null, "/Images/MERCEDES MAYBACH 3.WEBP", null, 2 },
                    { 14, null, null, "/Images/MERCEDES MAYBACH 4.WEBP", null, 2 },
                    { 15, null, null, "/Images/MERCEDES MAYBACH 5.WEBP", null, 2 },
                    { 16, null, null, "/Images/MERCEDES MAYBACH 6.WEBP", null, 2 },
                    { 17, null, null, "/Images/MERCEDES MAYBACH 7.WEBP", null, 2 },
                    { 18, null, null, "/Images/MERCEDES MAYBACH 8.WEBP", null, 2 },
                    { 19, null, null, "/Images/MERCEDES MAYBACH 9.WEBP", null, 2 },
                    { 20, null, null, "/Images/MERCEDES MAYBACH 10.WEBP", null, 2 },
                    { 21, null, null, "/Images/Toyota W251.WEBP", null, 3 },
                    { 22, null, null, "/Images/Toyota W252.WEBP", null, 3 },
                    { 23, null, null, "/Images/Toyota W254.WEBP", null, 3 },
                    { 24, null, null, "/Images/Toyota W255.WEBP", null, 3 },
                    { 25, null, null, "/Images/Toyota W256.WEBP", null, 3 },
                    { 26, null, null, "/Images/Mercedes-Benz GLC 1.WEBP", null, 4 },
                    { 27, null, null, "/Images/Mercedes-Benz GLC 2.WEBP", null, 4 },
                    { 28, null, null, "/Images/Mercedes-Benz GLC 3.WEBP", null, 4 },
                    { 29, null, null, "/Images/Mercedes-Benz GLC 4.WEBP", null, 4 },
                    { 30, null, null, "/Images/Mercedes-Benz GLC 5.WEBP", null, 4 },
                    { 31, null, null, "/Images/Mercedes-Benz GLC 6.WEBP", null, 4 },
                    { 32, null, null, "/Images/Mercedes-Benz GLC 7.WEBP", null, 4 },
                    { 33, null, null, "/Images/Mercedes-Benz GLC 8.WEBP", null, 4 },
                    { 34, null, null, "/Images/Mercedes-Benz GLC 9.WEBP", null, 4 },
                    { 35, null, null, "/Images/Mercedes-Benz GLC 10.WEBP", null, 4 },
                    { 36, null, null, "/Images/Mercedes Benz E200 1.WEBP", null, 5 },
                    { 37, null, null, "/Images/Mercedes Benz E200 1.WEBP", null, 5 },
                    { 38, null, null, "/Images/Mercedes Benz E200 2.WEBP", null, 5 },
                    { 39, null, null, "/Images/Mercedes Benz E200 3.WEBP", null, 5 },
                    { 40, null, null, "/Images/Mercedes Benz E200 4.WEBP", null, 5 },
                    { 41, null, null, "/Images/Mercedes Benz E200 5.WEBP", null, 5 },
                    { 42, null, null, "/Images/Mercedes Benz E200 6.WEBP", null, 5 },
                    { 43, null, null, "/Images/Mercedes Benz E200 7.WEBP", null, 5 },
                    { 44, null, null, "/Images/Mercedes Benz E200 8.WEBP", null, 5 },
                    { 45, null, null, "/Images/Mercedes Benz E200 9.WEBP", null, 5 },
                    { 46, null, null, "/Images/Mercedes Benz E200 10.WEBP", null, 5 },
                    { 47, null, null, "/Images/Volkswagen ID6 Crozz Pro 1.WEBP", null, 6 },
                    { 48, null, null, "/Images/Volkswagen ID6 Crozz Pro 2.WEBP", null, 6 },
                    { 49, null, null, "/Images/Volkswagen ID6 Crozz Pro 3.WEBP", null, 6 },
                    { 50, null, null, "/Images/Volkswagen ID6 Crozz Pro 4.WEBP", null, 6 },
                    { 51, null, null, "/Images/Volkswagen ID6 Crozz Pro 5.WEBP", null, 6 },
                    { 52, null, null, "/Images/Volkswagen ID6 Crozz Pro 6.WEBP", null, 6 },
                    { 53, null, null, "/Images/Volkswagen ID6 Crozz Pro 7.WEBP", null, 6 },
                    { 54, null, null, "/Images/Volkswagen ID6 Crozz Pro 8.WEBP", null, 6 },
                    { 55, null, null, "/Images/Volkswagen ID6 Crozz Pro 9.WEBP", null, 6 },
                    { 56, null, null, "/Images/Volkswagen ID6 Crozz Pro 10.WEBP", null, 6 },
                    { 57, null, null, "/Images/Porsche Taycan 2024 1.WEBP", null, 7 },
                    { 58, null, null, "/Images/Porsche Taycan 2024 2.WEBP", null, 7 },
                    { 59, null, null, "/Images/Porsche Taycan 2024 3.WEBP", null, 7 },
                    { 60, null, null, "/Images/Porsche Taycan 2024 4.WEBP", null, 7 },
                    { 61, null, null, "/Images/Porsche Taycan 2024 5.WEBP", null, 7 },
                    { 62, null, null, "/Images/Porsche Taycan 2024 6.WEBP", null, 7 },
                    { 63, null, null, "/Images/Porsche Taycan 2024 7.WEBP", null, 7 },
                    { 64, null, null, "/Images/Porsche Taycan 2024 8.WEBP", null, 7 },
                    { 65, null, null, "/Images/Porsche Taycan 2024 9.WEBP", null, 7 },
                    { 66, null, null, "/Images/Porsche Taycan 2024 10.WEBP", null, 7 },
                    { 67, null, null, "/Images/Range Rover Velar 2025 1.WEBP", null, 8 },
                    { 68, null, null, "/Images/Range Rover Velar 2025 2.WEBP", null, 8 },
                    { 69, null, null, "/Images/Range Rover Velar 2025 3.WEBP", null, 8 },
                    { 70, null, null, "/Images/Range Rover Velar 2025 4.WEBP", null, 8 },
                    { 71, null, null, "/Images/Range Rover Velar 2025 5.WEBP", null, 8 },
                    { 72, null, null, "/Images/Range Rover Velar 2025 6.WEBP", null, 8 },
                    { 73, null, null, "/Images/Range Rover Velar 2025 7.WEBP", null, 8 },
                    { 74, null, null, "/Images/Range Rover Velar 2025 8.WEBP", null, 8 },
                    { 75, null, null, "/Images/Range Rover Velar 2025 9.WEBP", null, 8 },
                    { 76, null, null, "/Images/Range Rover Velar 2025 10.WEBP", null, 8 },
                    { 77, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 1.WEBP", null, 9 },
                    { 78, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 2.WEBP", null, 9 },
                    { 79, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 3.WEBP", null, 9 },
                    { 80, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 4.WEBP", null, 9 },
                    { 81, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 5.WEBP", null, 9 },
                    { 82, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 6.WEBP", null, 9 },
                    { 83, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 7.WEBP", null, 9 },
                    { 84, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 8.WEBP", null, 9 },
                    { 85, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 9.WEBP", null, 9 },
                    { 86, null, null, "/Images/Skoda Kodiaq 2024 Laurin & Klement 10.WEBP", null, 9 },
                    { 87, null, null, "/Images/Porsche Macan 2024 1.WEBP", null, 10 },
                    { 88, null, null, "/Images/Porsche Macan 2024 2.WEBP", null, 10 },
                    { 89, null, null, "/Images/Porsche Macan 2024 3.WEBP", null, 10 },
                    { 90, null, null, "/Images/Porsche Macan 2024 4.WEBP", null, 10 },
                    { 91, null, null, "/Images/Porsche Macan 2024 5.WEBP", null, 10 },
                    { 92, null, null, "/Images/Porsche Macan 2024 6.WEBP", null, 10 },
                    { 93, null, null, "/Images/Porsche Macan 2024 7.WEBP", null, 10 },
                    { 94, null, null, "/Images/Hyundai Elantra 2025 1.WEBP", null, 11 },
                    { 95, null, null, "/Images/Hyundai Elantra 2025 2.WEBP", null, 11 },
                    { 96, null, null, "/Images/Hyundai Elantra 2025 3.WEBP", null, 11 },
                    { 97, null, null, "/Images/Hyundai Elantra 2025 4.WEBP", null, 11 },
                    { 98, null, null, "/Images/Hyundai Elantra 2025 5.WEBP", null, 11 },
                    { 99, null, null, "/Images/Hyundai Elantra 2025 6.WEBP", null, 11 },
                    { 100, null, null, "/Images/Hyundai Elantra 2025 7.WEBP", null, 11 },
                    { 101, null, null, "/Images/Hyundai Elantra 2025 8.WEBP", null, 11 },
                    { 102, null, null, "/Images/Hyundai Elantra 2025 9.WEBP", null, 11 },
                    { 103, null, null, "/Images/Hyundai Elantra 2025 10.WEBP", null, 11 },
                    { 104, null, null, "/Images/Kia EV5 2024 1.WEBP", null, 12 },
                    { 105, null, null, "/Images/Kia EV5 2024 2.WEBP", null, 12 },
                    { 106, null, null, "/Images/Kia EV5 2024 3.WEBP", null, 12 },
                    { 107, null, null, "/Images/Kia EV5 2024 4.WEBP", null, 12 },
                    { 108, null, null, "/Images/Kia EV5 2024 5.WEBP", null, 12 },
                    { 109, null, null, "/Images/Kia EV5 2024 6.WEBP", null, 12 },
                    { 110, null, null, "/Images/Kia EV5 2024 7.WEBP", null, 12 },
                    { 111, null, null, "/Images/Kia EV5 2024 8.WEBP", null, 12 },
                    { 112, null, null, "/Images/Kia EV5 2024 9.WEBP", null, 12 },
                    { 113, null, null, "/Images/Kia EV5 2024 10.WEBP", null, 12 },
                    { 114, null, null, "/Images/RANGE ROVE EVOQUE 2021 1.WEBP", null, 13 },
                    { 115, null, null, "/Images/RANGE ROVE EVOQUE 2021 2.WEBP", null, 13 },
                    { 116, null, null, "/Images/RANGE ROVE EVOQUE 2021 3.WEBP", null, 13 },
                    { 117, null, null, "/Images/RANGE ROVE EVOQUE 2021 4.WEBP", null, 13 },
                    { 118, null, null, "/Images/RANGE ROVE EVOQUE 2021 5.WEBP", null, 13 },
                    { 119, null, null, "/Images/RANGE ROVE EVOQUE 2021 6.WEBP", null, 13 },
                    { 120, null, null, "/Images/RANGE ROVE EVOQUE 2021 7.WEBP", null, 13 },
                    { 121, null, null, "/Images/RANGE ROVE EVOQUE 2021 8.WEBP", null, 13 },
                    { 122, null, null, "/Images/RANGE ROVE EVOQUE 2021 9.WEBP", null, 13 },
                    { 123, null, null, "/Images/RANGE ROVE EVOQUE 2021 10.WEBP", null, 13 },
                    { 124, null, null, "/Images/MG RX5 2024 1.WEBP", null, 14 },
                    { 125, null, null, "/Images/MG RX5 2024 2.WEBP", null, 14 },
                    { 126, null, null, "/Images/MG RX5 2024 3.WEBP", null, 14 },
                    { 127, null, null, "/Images/MG RX5 2024 4.WEBP", null, 14 },
                    { 128, null, null, "/Images/MG RX5 2024 5.WEBP", null, 14 },
                    { 129, null, null, "/Images/MG RX5 2024 6.WEBP", null, 14 },
                    { 130, null, null, "/Images/MG RX5 2024 7.WEBP", null, 14 },
                    { 131, null, null, "/Images/MG RX5 2024 8.WEBP", null, 14 },
                    { 132, null, null, "/Images/MG RX5 2024 9.WEBP", null, 14 },
                    { 133, null, null, "/Images/MG RX5 2024 10.WEBP", null, 14 },
                    { 134, null, null, "/Images/Audi Q4 E-Tron 2024 1.WEBP", null, 15 },
                    { 135, null, null, "/Images/Audi Q4 E-Tron 2024 2.WEBP", null, 15 },
                    { 136, null, null, "/Images/Audi Q4 E-Tron 2024 3.WEBP", null, 15 },
                    { 137, null, null, "/Images/Audi Q4 E-Tron 2024 4.WEBP", null, 15 },
                    { 138, null, null, "/Images/Audi Q4 E-Tron 2024 5.WEBP", null, 15 },
                    { 139, null, null, "/Images/Audi Q4 E-Tron 2024 6.WEBP", null, 15 },
                    { 140, null, null, "/Images/Audi Q4 E-Tron 2024 7.WEBP", null, 15 },
                    { 141, null, null, "/Images/Audi Q4 E-Tron 2024 8.WEBP", null, 15 },
                    { 142, null, null, "/Images/Audi Q4 E-Tron 2024 9.WEBP", null, 15 },
                    { 143, null, null, "/Images/Audi Q4 E-Tron 2024 10.WEBP", null, 15 },
                    { 144, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 1.WEBP", null, 16 },
                    { 145, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 2.WEBP", null, 16 },
                    { 146, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 3.WEBP", null, 16 },
                    { 147, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 4.WEBP", null, 16 },
                    { 148, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 5.WEBP", null, 16 },
                    { 149, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 6.WEBP", null, 16 },
                    { 150, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 7.WEBP", null, 16 },
                    { 151, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 8.WEBP", null, 16 },
                    { 152, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 9.WEBP", null, 16 },
                    { 153, null, null, "/Images/Changan S7 FULL ELECTRIC 2024 10.WEBP", null, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookingEventTickets_EventId",
                table: "BookingEventTickets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarlicenseImage_DriverId1",
                table: "CarlicenseImage",
                column: "DriverId1");

            migrationBuilder.CreateIndex(
                name: "IX_CarModel_BrandId",
                table: "CarModel",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRents_CarID",
                table: "CarRents",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId1",
                table: "Comments",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_CardNumber",
                table: "CreditCards",
                column: "CardNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverlicenseImage_DriverId1",
                table: "DriverlicenseImage",
                column: "DriverId1");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_EventId",
                table: "Hotels",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_ApplicationUserId",
                table: "RefreshTokens",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SparePartOrders_SparePartsId",
                table: "SparePartOrders",
                column: "SparePartsId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_UserId",
                table: "Trip",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBookings_UserId",
                table: "VehicleBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBookings",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_DriverId1",
                table: "VehicleImages",
                column: "DriverId1");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_SparePartsId",
                table: "VehicleImages",
                column: "SparePartsId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_VehicleId",
                table: "VehicleImages",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bestSellervehicles");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "BookingEventTickets");

            migrationBuilder.DropTable(
                name: "CarlicenseImage");

            migrationBuilder.DropTable(
                name: "CarModel");

            migrationBuilder.DropTable(
                name: "CarRents");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "DriverlicenseImage");

            migrationBuilder.DropTable(
                name: "HelpooOrders");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "JopApplications");

            migrationBuilder.DropTable(
                name: "Jops");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "RepairBookings");

            migrationBuilder.DropTable(
                name: "SparePartOrders");

            migrationBuilder.DropTable(
                name: "testimonials");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "VehicleBookings");

            migrationBuilder.DropTable(
                name: "VehicleImages");

            migrationBuilder.DropTable(
                name: "WashBookings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarsForrRents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
