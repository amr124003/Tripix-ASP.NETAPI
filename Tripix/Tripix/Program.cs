using DotNetEnv;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Authentication;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.SEEDING;
using Tripix.Services;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy => policy.SetIsOriginAllowed(origin => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .WithExposedHeaders("Access-Control-Allow-Origin"));

});

var mapConfig = TypeAdapterConfig.GlobalSettings;
mapConfig.Scan(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<IMapper>(new Mapper(mapConfig));

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITripRepo, TripRepo>();
builder.Services.AddScoped<IDriverRepo, DriverRepo>();
builder.Services.AddScoped<IJwtProvider, JwtPorvider>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<IBlog, BlogRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICarRepo, CarRepo>();
builder.Services.AddScoped<IRent, RentRepo>();
builder.Services.AddScoped<IRepair, RepairService>();

builder.Services.AddSingleton<PaymobService>(new PaymobService(
    builder.Configuration["Paymob:ApiKey"],
    builder.Configuration["Paymob:MerchantId"]
));

builder.Services.Configure<IdentityOptions>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;
    options.User.RequireUniqueEmail = true;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_.";
});

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});



builder.Configuration.AddUserSecrets<Program>();


Env.Load();

builder.Configuration.AddEnvironmentVariables();

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));




builder.Services.AddHttpClient<bininfoRepo>();
builder.Services.AddDbContext<ApplicationDbcontext>(options =>
{
    options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"))
           .EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information);
});

builder.Services.AddSignalR();





builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
}).AddEntityFrameworkStores<ApplicationDbcontext>()
   .AddDefaultTokenProviders();

var JwtSecret = builder.Configuration.GetSection("JwtOptions").Get<JwtOptions>();

Console.WriteLine(JwtSecret.SecretKey ?? "No Nulllllll");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {

            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSecret.SecretKey!)),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = JwtSecret?.Issure,
            ValidAudience = JwtSecret?.Audienece,
            ClockSkew = TimeSpan.Zero
        };
    }).AddGoogle(options =>
    {
        options.ClientId = Environment.GetEnvironmentVariable("GoogleClientId")!;
        options.ClientSecret = Environment.GetEnvironmentVariable("GoogleClientSecret");
    });

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your token."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});




builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

var scope = app.Services.CreateScope();
await Seedrole.InitializeAsync(scope.ServiceProvider);
await SeedSuperAdmin.InitializeAsync(scope.ServiceProvider);

app.MapHub<RideHub>("/trip");


app.UseCors("AllowAngularApp");
app.UseHttpsRedirection();


app.Use(async ( context, next ) =>
{
    try
    {
        context.Response.Headers.Remove("Cross-Origin-Opener-Policy");
        context.Response.Headers.Remove("Cross-Origin-Embedder-Policy");
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception: {ex.Message}");
        throw;
    }
});

app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<RideHub>("/ridehub");
    endpoints.MapHub<UserHub>("/userhub");
});

app.Run();
