using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMAF.Models
{
    public class IdentitySeedData
    {
        private const string Email = "gysgtgo@gmail.com";
        private const string Password = "Pa$$w0rd";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(Email);
            if (user == null)
            {
                user = new IdentityUser("gysgtgo@gmail.com");
                await userManager.CreateAsync(user, Password);
            }
        }
    }
}
