// Configuration management using appsettings.json 
using System;
using System.IO;    
using Microsoft.Extensions.Configuration;
class Program
{
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();

        string appName = config["Application:Name"];
        string version = config["Application:Version"];
        string connectionString = config.GetConnectionString("DefaultConnection");

        Console.WriteLine($"App Name: {appName}");
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Connection String: {connectionString}");
    }
}