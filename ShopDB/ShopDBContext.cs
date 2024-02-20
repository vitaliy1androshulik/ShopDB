using Microsoft.EntityFrameworkCore;
using ShopDB.Entities;
using ShopDB.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB
{
    public class ShopDBContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Position { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=ShopEXAMDB;
                                        Integrated Security=True;
                                        Connect Timeout=3;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shop>()
                .HasMany(a => a.Products)
                .WithMany(a=>a.Shops);
            modelBuilder.Entity<Shop>()
                .HasOne(a => a.City)
                .WithMany(a => a.Shops)
                .HasForeignKey(a => a.CityId);


            modelBuilder.Entity<Worker>()
                .HasOne(a=>a.Shop)
                .WithMany(a=>a.Workers)
                .HasForeignKey(a=>a.ShopId);
            modelBuilder.Entity<Worker>()
                .HasOne(a => a.Position)
                .WithMany(a => a.Workers)
                .HasForeignKey(a => a.PositionId);

            modelBuilder.Entity<Product>()
                .HasOne(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.CetegoryId);
            modelBuilder.Entity<Product>()
                .HasMany(a => a.Shops)
                .WithMany(a => a.Products);

            modelBuilder.Entity<City>()
                .HasOne(a => a.Country)
                .WithMany(a => a.Cities)
                .HasForeignKey(a => a.CountryId);

            modelBuilder.SeedCountry();
            modelBuilder.SeedCities();
            modelBuilder.SeedCategories();
            modelBuilder.SeedPosition();
            modelBuilder.SeedShop();
            modelBuilder.SeedWorkers();
            modelBuilder.SeedProducts();

        }
    }
}
