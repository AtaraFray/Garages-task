using GaragesBLL;
using GaragesDAL;
using GaragesDAL.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGarageBLL, GarageBLL>();
builder.Services.AddScoped<IGaragesDAL, GarageDAL>();

var connectionString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<GaragesDBContext>(options =>
    options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors(p => p.AddPolicy("AlowAll", option =>
{
    option.AllowAnyMethod();
    option.AllowAnyHeader();
    option.AllowAnyOrigin();
}));

var app = builder.Build();
app.UseCors("AlowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
