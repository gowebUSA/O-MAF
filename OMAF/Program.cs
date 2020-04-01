using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OMAF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //Notes:
        //200331:1206. Redid the Razor View bec it was not woking earlier. Next thi to-do:DONE.
        //////docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio#change-views-and-layout-pages
        //TO-DO:DONE. docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio#passing-data-from-the-controller-to-the-view
        //////A best practice: View templates should not perform business logic or interact with a database directly.
        //TODO: docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio#add-a-data-model-class
        ////POCO:  Plain Old CLR Objects
        //////Installed NuGey package Microsoft.EntityFrameworkCore.SqlServer.
        //////If use PowerShell, use code: Install-Package Microsoft.EntityFrameworkCore.SqlServer
        ////
        ///
        //
        //
        //
        //
        //
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
