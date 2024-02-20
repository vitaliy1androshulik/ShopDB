using Microsoft.EntityFrameworkCore;
using ShopDB.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Helpers
{
    public static class DBInitializer
    {
        public static void SeedCountry(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                 new Country()
                 {
                     Id=1,
                    Name="Ukraine"
                 },
                new Country()
                 {
                    Id=2,
                    Name="Poland"
                 },
                 new Country()
                 {
                     Id=3,
                    Name="Austria"
                 },
                 new Country()
                 {
                     Id=4,
                    Name="France"
                 },
                 new Country()
                 {
                     Id=5,
                    Name="Germany"
                 },
                 new Country()
                 {
                     Id=6,
                    Name="Spain"
                 },
                 new Country()
                 {
                     Id=7,
                    Name="Portugal"
                 },
                 new Country()
                 {
                     Id=8,
                    Name="Estonia"
                 },
                 new Country()
                 {
                     Id=9,
                    Name="China"
                 },
                 new Country()
                 {
                     Id=10,
                    Name="Japan"
                 },
                 new Country()
                 {
                     Id=11,
                    Name="Egypt"
                 },
            });
        }
        public static void SeedCities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City()
                {
                    Id=1,
                    Name="Kyiv",
                    CountryId=1
                },
                new City()
                {
                    Id=2,
                    Name="Rivne",
                    CountryId=1
                },
                new City()
                {
                    Id=3,
                    Name="Odesa",
                    CountryId=1
                },
                new City()
                {
                    Id=4,
                    Name="Tokyo",
                    CountryId=10
                },
                new City()
                {
                    Id=5,
                    Name="Warshava",
                    CountryId=10
                },
                new City()
                {
                    Id=6,
                    Name="Krakow",
                    CountryId=10
                },
                new City()
                {
                    Id=7,
                    Name="Katowice",
                    CountryId=10
                },
                new City()
                {
                    Id=8,
                    Name="Warshava",
                    CountryId=10
                },
                new City()
                {
                    Id=9,
                    Name="Parish",
                    CountryId=4
                }
            });
        }
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category()
                {
                    Id=1,
                    Name="Equipment"
                },
                new Category()
                {
                    Id=2,
                    Name="Food"
                },
                new Category()
                {
                    Id=3,
                    Name="Sport-Food"
                },
                new Category()
                {
                    Id=4,
                    Name="Sport-inventory"
                },
                new Category()
                {
                    Id=5,
                    Name="Gadgets"
                },
                new Category()
                {
                    Id=6,
                    Name="Household appliance"
                }
            });
        }
        public static void SeedPosition(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(new Position[]
            {
                new Position()
                {
                    Id=1,
                    Name = "Manager"
                },
                new Position()
                {
                    Id = 2,
                    Name="Worker"
                },
                new Position()
                {
                    Id=3,
                    Name="Casier"
                },
                new Position()
                {
                    Id=4,
                    Name="Cleaner"
                }
            });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(new Worker[]
            {
                new Worker()
                {
                    Id=1,
                    Name="Mukola",
                    Surname="Bondarenko",
                    Salary=10000,
                    Email="br@gmail.com",
                    PhoneNumber="0987654321",
                    PositionId=2,
                    ShopId=1,
                },
                new Worker()
                {
                    Id=2,
                    Name="Andriy",
                    Surname="Andriyenko",
                    Salary=15000,
                    Email="andriy@gmail.com",
                    PhoneNumber="9786555252",
                    PositionId=1,
                    ShopId=2,
                },
                new Worker()
                {

                    Id=3,
                    Name="Sergiy",
                    Surname="Yarmolenko",
                    Salary=10000,
                    Email="yarmolenko@gmail.com",
                    PhoneNumber="09873232321",
                    PositionId=3,
                    ShopId=2,
                },
                new Worker()
                {

                    Id=4,
                    Name="Yaroslawa",
                    Surname="China",
                    Salary=10000,
                    Email="waroslwkas@gmail.com",
                    PhoneNumber="1231231231",
                    PositionId=3,
                    ShopId=3,
                }
            });
        }
        public static void SeedShop(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Shop>().HasData(new Shop[]
            {
                new Shop()
                {

                    Id=1,
                    Name="ATB",
                    Address="Chinazes",
                    CityId=2,
                    ParkingArea=1
                },
                new Shop()
                {

                    Id=2,
                    Name="Borsch",
                    Address="Kyracha-12",
                    CityId=1,
                    ParkingArea=3
                },
                new Shop()
                {Id = 3,
                    Name="AntiSeptik",
                    Address="Doctor-42B",
                    CityId=2,
                    ParkingArea=2
                }
            });
        }
        public static void SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product()
                {
                    Id=1,
                    Name="Gantela",
                    Price=1200,
                    Discount=2,
                    CetegoryId=4,
                    Quantity=2,
                    IsInStock=true
                },
                new Product()
                {Id = 2,
                    Name="Apple",
                    Price=50,
                    Discount=0,
                    CetegoryId=2,
                    Quantity=100,
                    IsInStock=true
                },
                new Product()
                {Id=3,
                    Name="Banana",
                    Price=75,
                    Discount=0,
                    CetegoryId=2,
                    Quantity=50,
                    IsInStock=true
                },
                new Product()
                {Id = 4,
                    Name="Ball",
                    Price=2500,
                    Discount=15,
                    CetegoryId=4,
                    Quantity=5,
                    IsInStock=true
                },
                new Product()
                {Id=5,
                    Name="SmartPhone Somsing B12",
                    Price=9800,
                    Discount=1,
                    CetegoryId=5,
                    Quantity=2,
                    IsInStock=true
                }
            }) ;
        }
    }
}
