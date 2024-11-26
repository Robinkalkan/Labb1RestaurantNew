﻿// <auto-generated />
using System;
using Labb1Restaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb1Restaurant.Migrations
{
    [DbContext(typeof(Labb1RestaurantContext))]
    [Migration("20241126170439_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb1Restaurant.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("BookingEnd")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("BookingStart")
                        .HasColumnType("time");

                    b.Property<int>("FK_CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("FK_TableId")
                        .HasColumnType("int");

                    b.Property<int>("GuestAttending")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FK_CustomerId");

                    b.HasIndex("FK_TableId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookingDate = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookingEnd = new TimeSpan(0, 19, 0, 0, 0),
                            BookingStart = new TimeSpan(0, 18, 0, 0, 0),
                            FK_CustomerId = 1,
                            FK_TableId = 1,
                            GuestAttending = 2
                        },
                        new
                        {
                            Id = 2,
                            BookingDate = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookingEnd = new TimeSpan(0, 21, 0, 0, 0),
                            BookingStart = new TimeSpan(0, 20, 0, 0, 0),
                            FK_CustomerId = 2,
                            FK_TableId = 2,
                            GuestAttending = 4
                        },
                        new
                        {
                            Id = 3,
                            BookingDate = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookingEnd = new TimeSpan(0, 22, 0, 0, 0),
                            BookingStart = new TimeSpan(0, 21, 0, 0, 0),
                            FK_CustomerId = 3,
                            FK_TableId = 3,
                            GuestAttending = 6
                        });
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "hallu.kevin@outlook.com",
                            FirstName = "hallu",
                            LastName = "kevin",
                            PhoneNumber = "070623454"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Robz.muuu@hotmail.com",
                            FirstName = "Robz",
                            LastName = "Mori",
                            PhoneNumber = "070583722"
                        },
                        new
                        {
                            Id = 3,
                            Email = "syntia.lulu@yahoo.com",
                            FirstName = "synthia",
                            LastName = "lulu",
                            PhoneNumber = "0707263534"
                        });
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FoodInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FoodPrice")
                        .HasColumnType("float");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPopular")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodInfo = "Homemade pasta Alfredo.",
                            FoodName = "Pasta Alfredo",
                            FoodPrice = 155.0,
                            IsAvailable = true,
                            IsPopular = true
                        },
                        new
                        {
                            Id = 2,
                            FoodInfo = "Big Ass Pizza For You.",
                            FoodName = "Pizza",
                            FoodPrice = 270.0,
                            IsAvailable = true,
                            IsPopular = true
                        },
                        new
                        {
                            Id = 3,
                            FoodInfo = "Perfect Made Lasagne.",
                            FoodName = "Lasagne",
                            FoodPrice = 180.0,
                            IsAvailable = true,
                            IsPopular = false
                        },
                        new
                        {
                            Id = 4,
                            FoodInfo = "A Freash sallad with tuna",
                            FoodName = "Sallad",
                            FoodPrice = 135.0,
                            IsAvailable = true,
                            IsPopular = false
                        },
                        new
                        {
                            Id = 5,
                            FoodInfo = "Served with mashed potatoes.",
                            FoodName = "minute steak",
                            FoodPrice = 210.0,
                            IsAvailable = true,
                            IsPopular = true
                        },
                        new
                        {
                            Id = 6,
                            FoodInfo = "Homemade hamburger with fries.",
                            FoodName = "Hamburger",
                            FoodPrice = 185.0,
                            IsAvailable = true,
                            IsPopular = false
                        },
                        new
                        {
                            Id = 7,
                            FoodInfo = "Babyfood for your baby",
                            FoodName = "babyfood",
                            FoodPrice = 380.0,
                            IsAvailable = true,
                            IsPopular = true
                        });
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<int>("TableSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TableNumber = 1,
                            TableSeats = 4
                        },
                        new
                        {
                            Id = 2,
                            TableNumber = 2,
                            TableSeats = 4
                        },
                        new
                        {
                            Id = 3,
                            TableNumber = 3,
                            TableSeats = 6
                        },
                        new
                        {
                            Id = 4,
                            TableNumber = 4,
                            TableSeats = 6
                        },
                        new
                        {
                            Id = 5,
                            TableNumber = 5,
                            TableSeats = 8
                        },
                        new
                        {
                            Id = 6,
                            TableNumber = 6,
                            TableSeats = 8
                        });
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Booking", b =>
                {
                    b.HasOne("Labb1Restaurant.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("FK_CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1Restaurant.Models.Table", "Table")
                        .WithMany("Bookings")
                        .HasForeignKey("FK_TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Labb1Restaurant.Models.Table", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}