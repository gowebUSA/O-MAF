using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using OMAF.Data;
using OMAF.Models;

namespace OMAF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();        //Commented out on docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-3.1&tabs=visual-studio#add-the-seed-initializer
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//Notes:
//200331:1206. Redid the Razor View bec it was not woking earlier. Next thi to-do:DONE.
//////docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio#change-views-and-layout-pages
//TO-DO:DONE. docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio#passing-data-from-the-controller-to-the-view
//////A best practice: View templates should not perform business logic or interact with a database directly.
//TODO: docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#add-a-data-model-class
////POCO:  Plain Old CLR Objects
//////Installed NuGet package Microsoft.EntityFrameworkCore.SqlServer v3.1.1.
//////If use PowerShell, use code: Install-Package Microsoft.EntityFrameworkCore.SqlServer v3.1.1. If you install the newer, it will throw an exception.
//
//
//
//
//
//
//
