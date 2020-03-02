using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JammedComputers.Models;

namespace JammedComputers.Data
{
    public class JammedComputersContext : DbContext
    {
        public JammedComputersContext (DbContextOptions<JammedComputersContext> options)
            : base(options)
        {
        }

        public DbSet<JammedComputers.Models.Blog> Blog { get; set; }
    }
}
