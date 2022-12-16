/*
 * Using .NET 6 calling Configure twice will load the same string only once
 * 
 * The appsetting is defined in the appsettings.development.json
 * 
 * Output is {"nam":{"eastus2":["Test"]}} as expected.
 */

using ConfigurationProvider.Net6.DoubleConfigure.Working;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddOptions();

// Double calling this will NOT double load the single "Test" string
builder.Services.Configure<TestOptions>(builder.Configuration.GetSection(TestOptions.SettingName));

builder.Services.Configure<TestOptions>(builder.Configuration.GetSection(TestOptions.SettingName));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();