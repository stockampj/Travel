﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191029202154_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Travel.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Joel",
                            LastName = "Stockamp",
                            Password = "hello",
                            Username = "stockampj"
                        });
                });

            modelBuilder.Entity("Travel.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<int>("CountryId");

                    b.Property<double>("Rating");

                    b.Property<int>("ReviewCount");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 3,
                            CityName = "Los Angelos",
                            CountryId = 1,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Paris",
                            CountryId = 2,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Venice",
                            CountryId = 3,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Hong Kong",
                            CountryId = 4,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "London",
                            CountryId = 5,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Delhi",
                            CountryId = 6,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 9,
                            CityName = "Nairobi",
                            CountryId = 7,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 10,
                            CityName = "Bali",
                            CountryId = 8,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 11,
                            CityName = "Brasilia",
                            CountryId = 9,
                            Rating = 0.0,
                            ReviewCount = 0
                        },
                        new
                        {
                            CityId = 12,
                            CityName = "Portland",
                            CountryId = 1,
                            Rating = 0.0,
                            ReviewCount = 0
                        });
                });

            modelBuilder.Entity("Travel.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Italy"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Hong Kong"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "England"
                        },
                        new
                        {
                            CountryId = 6,
                            CountryName = "India"
                        },
                        new
                        {
                            CountryId = 7,
                            CountryName = "Kenya"
                        },
                        new
                        {
                            CountryId = 8,
                            CountryName = "Indonesia"
                        },
                        new
                        {
                            CountryId = 9,
                            CountryName = "Brasil"
                        });
                });

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Blurb")
                        .HasMaxLength(255);

                    b.Property<int>("CityId");

                    b.Property<double>("Rating");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Travel.Models.City", b =>
                {
                    b.HasOne("Travel.Models.Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.HasOne("Travel.Models.City")
                        .WithMany("Reviews")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Travel.Entities.User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
