using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMAF.Models;

namespace OMAF.Data
{
    public class OmafContext : DbContext
    {
        public OmafContext(DbContextOptions<OmafContext> options)
            : base(options)
        {
        }

        public DbSet<Aircraft> Movie { get; set; }
    }
}
