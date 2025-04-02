using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Tripix.Context;
using Tripix.Entities;
using Tripix.SEEDING;
using Tripix.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy => policy.SetIsOriginAllowed(origin => true) // Ì”„Õ »√Ì Origin
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithExposedHeaders("Access-Control-Allow-Origin")); // ﬂ‘› «·ÂÌœ—
});

builder.Configuration.AddUserSecrets<Program>();


Env.Load();

builder.Configuration.AddEnvironmentVariables();




builder.Services.AddHttpClient<bininfoRepo>();
builder.Services.AddDbContext<ApplicationDbcontext>(options =>
{
    options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));
});




builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
}).AddEntityFrameworkStores<ApplicationDbcontext>()
   .AddDefaultTokenProviders();

var JwtSecret = Environment.GetEnvironmentVariable("JWTSecret");

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
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSecret)),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = "SecureAPI",
            ValidAudience = "Securezzz",
            ClockSkew = TimeSpan.Zero
        };
    }).AddGoogle(options =>
    {
        options.ClientId = Environment.GetEnvironmentVariable("GoogleClientId");
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


app.UseCors("AllowAngularApp");
app.UseHttpsRedirection();


app.Use(async ( context, next ) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception: {ex.Message}");
        throw;
    }
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
