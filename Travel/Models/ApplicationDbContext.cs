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
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasData(
                    new City {CityId = 3, CityName = "Los Angelos", CountryId = 1},
                    new City {CityId = 4, CityName = "Paris", CountryId = 2},
                    new City {CityId = 5, CityName = "Venice", CountryId = 3},
                    new City {CityId = 6, CityName = "Hong Kong", CountryId = 4},
                    new City {CityId = 7, CityName = "London", CountryId = 5},
                    new City {CityId = 8, CityName = "Delhi", CountryId = 6},
                    new City {CityId = 9, CityName = "Nairobi", CountryId = 7},
                    new City {CityId = 10, CityName = "Bali", CountryId = 8},
                    new City {CityId = 11, CityName = "Brasilia", CountryId = 9},
                    new City {CityId = 12, CityName = "Portland", CountryId = 1}
                );

            builder.Entity<Country>()
                .HasData(
                    new Country {CountryId = 1, CountryName = "USA"},
                    new Country {CountryId = 2, CountryName = "France"},
                    new Country {CountryId = 3, CountryName = "Italy"},
                    new Country {CountryId = 4, CountryName = "Hong Kong"},
                    new Country {CountryId = 5, CountryName = "England"},
                    new Country {CountryId = 6, CountryName = "India"},
                    new Country {CountryId = 7, CountryName = "Kenya"},
                    new Country {CountryId = 8, CountryName = "Indonesia"},
                    new Country {CountryId = 9, CountryName = "Brasil"}
                );
        }
    }
}