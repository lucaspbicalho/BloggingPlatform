using BloggingPlatform.Infrasctructure.Contexts;
using BloggingPlatform.Infrasctructure.Repositories;
using BloggingPlatform.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//add serilog 
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));
//configure InMemory context 
builder.Services.AddDbContext<BloggingPlatformDbContext>(db => db.UseInMemoryDatabase("BloggingPlatformDb"));
// Repository
builder.Services.AddScoped<IBloggingPlatformRepository, BloggingPlatformRepository>();
// Services
builder.Services.AddScoped<BloggingPlatformService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//add serilog Console
app.UseSerilogRequestLogging();

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
