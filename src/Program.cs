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
                .AddUserSecrets<Program>()
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddDbContext<CdsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("cds")))
                .AddSingleton<IApp, App>()
                .BuildServiceProvider();

            serviceProvider.GetService<IApp>().Run();
        }
    }
}
