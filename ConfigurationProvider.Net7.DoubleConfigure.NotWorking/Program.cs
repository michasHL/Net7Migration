/*
 * Using .NET 7 calling Configure twice will load the same string twice into a string array.
 * 
 * The appsetting is defined in the appsettings.development.json
 * 
 * Output is {"nam":{"eastus2":["Test","Test"]}}
 * 'Test should only be in there once
 */

using ConfigurationProvider.Net7.DoubleConfigure.NotWorking;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddOptions();

// Double calling this will double load the single "Test" string
builder.Services.Configure<TestOptions>(builder.Configuration.GetSection(TestOptions.SettingName));

builder.Services.Configure<TestOptions>(builder.Configuration.GetSection(TestOptions.SettingName));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();