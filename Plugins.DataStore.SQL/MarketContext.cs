using Microsoft.EntityFrameworkCore;
using CoreBusiness;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding some data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Category №1", Description = "Desription №1" },
                new Category { CategoryId = 2, Name = "Category №2", Description = "Desription №2" },
                new Category { CategoryId = 3, Name = "Category №3", Description = "Desription №3" },
                new Category { CategoryId = 4, Name = "Category №4", Description = "Desription №4" },
                new Category { CategoryId = 5, Name = "Category №5", Description = "Desription №5" },
                new Category { CategoryId = 6, Name = "Category №6", Description = "Desription №6" }
                );
        }
    }
}
