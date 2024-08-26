using frm.Models;
using Microsoft.EntityFrameworkCore;
// using Serilog;

var builder = WebApplication.CreateBuilder(args);

// builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
// builder.Logging.ClearProviders();
// builder.Logging.AddSerilog();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<FrmContext>((options) => options.UseSqlServer(connectionString));
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
