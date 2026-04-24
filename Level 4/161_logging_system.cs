// Logging system using Serilog 
using Serilog;

class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        Log.Information("Application started.");
        // Your application logic here
        Log.Information("Application finished.");
    }
}
