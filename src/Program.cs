using System;
using Microsoft.Extensions.Configuration;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

                var connectionString = Configuration.GetConnectionString("cds");

                Console.ReadKey();
        }
    }
}
