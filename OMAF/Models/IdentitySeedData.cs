using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OMAF.Models
{
    public static class IdentitySeedData
    {
        //public static void SeedId(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AspNetUsers>().HasData(
        //        new AspNetUsers
        //        {
        //            Email = "gysgtgo@gmail.com",
        //            Password = "Pa$$w0rd"
        //        }
        //        );
        //}
        private const string Email = "gysgtgo@gmail.com";
        private const string PasswordHash = "Pa$$w0rd";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(Email);
            if (user == null)
            {
                user = new IdentityUser("gysgtgo@gmail.com");
                await userManager.CreateAsync(user, PasswordHash);
            }
        }
        //Also see Startup.cs line 78 = IdentitySeedData.EnsurePopulated(app);
    }
}
