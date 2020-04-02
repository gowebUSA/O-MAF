using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OMAF.Data;

namespace OMAF.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OmafContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OmafContext>>()))
            {
                // Look for any aircraft.
                if (context.Aircraft.Any())
                {
                    return;   // DB has been seeded
                }

                context.Aircraft.AddRange(
                    new Aircraft
                    {
                        SysReason = "AFC 285",
                        InitiateDate = DateTime.Parse("2020-2-12"),
                        BUNO = 168661,
                        UDP = 1
                    },

                    new Aircraft
                    {
                        SysReason = "PPC 14",
                        InitiateDate = DateTime.Parse("2020-1-22"),
                        BUNO = 168662,
                        UDP = 2
                    },

                    new Aircraft
                    {
                        SysReason = "DCC 12",
                        InitiateDate = DateTime.Parse("2020-3-1"),
                        BUNO = 168663,
                        UDP = 3
                    },

                    new Aircraft
                    {
                        SysReason = "CSC 173 RA",
                        InitiateDate = DateTime.Parse("2020-1-8"),
                        BUNO = 168664,
                        UDP = 1
                    }
                );
                context.SaveChanges();          //This could be commented out later when I use my Azure database.
            }
        }
    }
}
