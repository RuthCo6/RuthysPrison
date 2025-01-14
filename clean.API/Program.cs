using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Service;
using Clean.Data.Repositories;
using Clean.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Prison-guard
builder.Services.AddScoped<IPrison_GuardRepository, Prison_GuardRepository>();
builder.Services.AddScoped<IPrison_GuardService, Prison_GuardService>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<DataContext>();
//Prisoner
builder.Services.AddScoped<IPrisonerRepository, PrisonerRepository>();
builder.Services.AddScoped<IPrisonerService, PrisonerService>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<DataContext>();
//Room
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<DataContext>();
var app = builder.Build();

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
