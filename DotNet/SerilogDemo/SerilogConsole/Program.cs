using Serilog;
using System;

namespace SerilogConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("Logs/log.txt",
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Information("Hello, Serilog!");

            Log.CloseAndFlush();

            // Log is close after
            Log.Information("Hello, Serilog2222!");

            Console.WriteLine("Hello World!");
        }

    }
}
