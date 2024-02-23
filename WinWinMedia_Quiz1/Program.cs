using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using UserManagement.DBModels;
using UserManagement.Services.ApiService;
using UserManagement.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connString = builder.Configuration.GetConnectionString("WinWin");
builder.Services.AddDbContext<WinWinDBContext>(option =>
{
    option.UseSqlServer(connString, options =>
    {
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
_ = builder.Services.AddSwaggerGen(swagger =>
{
    //±Ò¥ÎSwaggerResponseµù¸Ñ
    swagger.EnableAnnotations();

    swagger.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "WinWin Media",
        Version = "v1"
    });

    var apiXmlPath = Path.Combine(AppContext.BaseDirectory, "Quiz1.xml");
    swagger.IncludeXmlComments(apiXmlPath);
});

builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IRegionService, RegionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
