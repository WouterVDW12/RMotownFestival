using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Stage> Stages { get; set; }

        public MotownDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
