using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie2023SummerLearnFest.Models;

namespace MVCMovie2023SummerLearnFest.Data
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext (DbContextOptions<MVCMovieContext> options)
            : base(options)
        {
        }

        // use this also to seed the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MVCMovie2023SummerLearnFest.Models.Movie> Movie { get; set; } = default!;
    }
}
