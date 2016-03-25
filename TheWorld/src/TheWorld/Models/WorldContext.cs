using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace TheWorld.Models
{
    class WorldContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Trip> Stops { get; set; }
    }
}
