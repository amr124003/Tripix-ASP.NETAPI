using DotNetEnv;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Authentication;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.SEEDING;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy =>
        policy.WithOrigins("https://localhost:4200") 
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials()
    );
});

var mapConfig = TypeAdapterConfig.GlobalSettings;
mapConfig.Scan(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<IMapper>(new Mapper(mapConfig));

builder.Services.Configure<FormOptions>(option =>
{

    option.MultipartBodyLengthLimit = 104857600;
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJwtProvider, JwtProvider>();


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

Env.Load();

builder.Configuration.AddEnvironmentVariables();

var Redis_Password = Environment.GetEnvironmentVariable("Redis_Password");

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = $"first-mako-36762.upstash.io:6379,password={Redis_Password},ssl=True,abortConnect=False";
});

builder.Configuration.AddUserSecrets<Program>();

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
builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

var scope = app.Services.CreateScope();
await Seedrole.InitializeAsync(scope.ServiceProvider);
await SeedSuperAdmin.InitializeAsync(scope.ServiceProvider);

app.MapHub<RideHub>("/trip");


app.UseCors("AllowAngularApp");
app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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





app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<RideHub>("/ridehub");
    endpoints.MapHub<UserHub>("/userhub");
});

app.Run();
