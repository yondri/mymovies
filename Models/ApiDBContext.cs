using mymovies.Maps;
using Microsoft.EntityFrameworkCore;
using mymovies.Models;
using System;

namespace mymovies.Models{
#pragma warning disable CS1591
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
       : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new MovieMap(modelBuilder.Entity<Movie>());
        }
    }
    #pragma warning restore CS1591
}