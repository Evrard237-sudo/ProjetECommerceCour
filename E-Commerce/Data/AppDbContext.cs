using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;

namespace E_Commerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<E_Commerce.Models.Movie> Movie { get; set; } = default!;

        public DbSet<E_Commerce.Models.Actor> Actor { get; set; } = default!;

        public DbSet<E_Commerce.Models.Cinema> Cinema { get; set; }

        public DbSet<E_Commerce.Models.Actor_Movie> Actor_Movie { get; set; }
    }
}
