/*
 * Using .NET 7 but Microsoft.Extensions.Configuration.Binder 6.0.0 default comparer is OrdinalIgnoreCase
 */

using Configuration.Binder.Working;
using Microsoft.Extensions.Configuration;


IConfiguration config = new ConfigurationBuilder()
    .AddInMemoryCollection()
    .Build();

config["Regions:0"] = "EastUs2";
config["Regions:1"] = "WestUs2";

TestObject obj = config.Get<TestObject>()!;
Console.WriteLine($"Test object contains westus2: {obj.Regions.Contains("westus2")}");