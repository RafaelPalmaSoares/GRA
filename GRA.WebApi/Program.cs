using GRA.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.WebApi
{
    public class Program
    {

        private ServiceCollection serviceCollection = new ServiceCollection();
        public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var movieService = services.GetRequiredService<IMovieService>();
                    var configuration = services.GetRequiredService<IConfiguration>();

                    movieService.LoadCSV(configuration["PathCSV"]);
                }
                catch(Exception ex)
                {
                    new Exception(ex.Message);
                }   
            }
            host.Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var serviceCollection = new ServiceCollection();
                    webBuilder.UseStartup<Startup>();
                });

    }
}
