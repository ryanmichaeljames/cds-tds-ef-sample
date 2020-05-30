using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            var serviceProvider = new ServiceCollection()
                .AddDbContext<CdsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("cds")))
                .AddSingleton<App, App>()
                .BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }
    }
}
