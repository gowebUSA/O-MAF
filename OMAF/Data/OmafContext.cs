using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OMAF.Models;

namespace OMAF.Data
{
    public class OmafContext : IdentityDbContext
    {
        public OmafContext(DbContextOptions<OmafContext> options)
            : base(options)
        {
        }

        public DbSet<Aircraft> Aircraft { get; set; }               //row in a table.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.SeedId();            //kudvenkat SeedId.
        }
    }
}
