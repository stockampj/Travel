using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasData(
                    new City {CityId = 3, CityName = "Los Angelos"},
                    new City {CityId = 4, CityName = "Paris"},
                    new City {CityId = 5, CityName = "Venice"},
                    new City {CityId = 6, CityName = "Hong Kong"},
                    new City {CityId = 7, CityName = "London"},
                    new City {CityId = 8, CityName = "Delhi"},
                    new City {CityId = 9, CityName = "Nairobi"},
                    new City {CityId = 10, CityName = "Bali"},
                    new City {CityId = 11, CityName = "Brasilia"}
                );
        }
    }
}