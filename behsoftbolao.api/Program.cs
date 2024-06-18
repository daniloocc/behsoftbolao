using BehSoft.DataAccess.Repository;
using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;
using behsoftbolao.api.Managers;
using behsoftbolao.api.Managers.Interfaces;
using behsoftbolao.api.Mappings;
using behsoftbolao.api.Middlewares;
using behsoftbolao.api.Repository;
using behsoftbolao.api.Repository.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// TODO: Colocar configurações no appsetting.json
var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("Logs/behsoft_bolao_.txt", rollingInterval: RollingInterval.Day)
    .MinimumLevel.Information()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "BehSoft Bolão API", Version = "v1" });
    opt.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme
    });

    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id=JwtBearerDefaults.AuthenticationScheme
                },
                Scheme="Oauth2",
                Name=JwtBearerDefaults.AuthenticationScheme,
                In=ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

builder.AddNpgsqlDbContext<BolaoDbContext>("Aspire:Npgsql:EntityFrameworkCore:PostgreSQL");
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);// timestamp with timezone
builder.AddNpgsqlDbContext<BolaoAuthDbContext>("Aspire:Npgsql:EntityFrameworkCore:PostgreSQL:BolaoAuthDbContext");

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITokenRepository, TokenRepository>();
builder.Services.AddScoped<IBolaoManager, BolaoManager>();
builder.Services.AddScoped<IImageRepository, LocalImageRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddIdentityCore<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>("BsBolao")
    .AddEntityFrameworkStores<BolaoAuthDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequiredLength = 6;
    opt.Password.RequiredUniqueChars = 1;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.MapControllers();

app.Run();
