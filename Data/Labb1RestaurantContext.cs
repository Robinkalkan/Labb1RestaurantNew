using Labb1Restaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb1Restaurant.Data
{
    public class Labb1RestaurantContext : DbContext
    {
        public Labb1RestaurantContext(DbContextOptions<Labb1RestaurantContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData
                (
                new Customer { Id = 1, FirstName = "hallu", LastName = "kevin", Email = "hallu.kevin@outlook.com", PhoneNumber = "070623454" },
                new Customer { Id = 2, FirstName = "Robz", LastName = "Mori", Email = "Robz.muuu@hotmail.com", PhoneNumber = "070583722" },
                new Customer { Id = 3, FirstName = "synthia", LastName = "lulu", Email = "syntia.lulu@yahoo.com", PhoneNumber = "0707263534" }
                );

            modelBuilder.Entity<Table>().HasData
                (
                    new Table { Id = 1, TableNumber = 1, TableSeats = 4 },
                    new Table { Id = 2, TableNumber = 2, TableSeats = 4 },
                    new Table { Id = 3, TableNumber = 3, TableSeats = 6 },
                    new Table { Id = 4, TableNumber = 4, TableSeats = 6 },
                    new Table { Id = 5, TableNumber = 5, TableSeats = 8 },
                    new Table { Id = 6, TableNumber = 6, TableSeats = 8 }
                );

            modelBuilder.Entity<Menu>().HasData
                (
                    new Menu { Id = 1, FoodName = "Pasta Alfredo", FoodInfo = "Homemade pasta Alfredo.", FoodPrice = 155, IsPopular = true, IsAvailable = true },
                    new Menu { Id = 2, FoodName = "Pizza", FoodInfo = "Big Ass Pizza For You.", FoodPrice = 270, IsPopular = true, IsAvailable = true },
                    new Menu { Id = 3, FoodName = "Lasagne", FoodInfo = "Perfect Made Lasagne.", FoodPrice = 180, IsPopular = false, IsAvailable = true },
                    new Menu { Id = 4, FoodName = "Sallad", FoodInfo = "A Freash sallad with tuna", FoodPrice = 135, IsPopular = false, IsAvailable = true },
                    new Menu { Id = 5, FoodName = "minute steak", FoodInfo = "Served with mashed potatoes.", FoodPrice = 210, IsPopular = true, IsAvailable = true },
                    new Menu { Id = 6, FoodName = "Hamburger", FoodInfo = "Homemade hamburger with fries.", FoodPrice = 185, IsPopular = false, IsAvailable = true },
                    new Menu { Id = 7, FoodName = "babyfood", FoodInfo = "Babyfood for your baby", FoodPrice = 380, IsPopular = true, IsAvailable = true }

                );

            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 1,
                    FK_CustomerId = 1,
                    FK_TableId = 1,
                    BookingDate = new DateTime(2024, 11, 7),
                    BookingStart = new TimeSpan(18, 0, 0),
                    BookingEnd = new TimeSpan(19, 0, 0),
                    GuestAttending = 2
                },
                new Booking
                {
                    Id = 2,
                    FK_CustomerId = 2,
                    FK_TableId = 2,
                    BookingDate = new DateTime(2024, 11, 7),
                    BookingStart = new TimeSpan(20, 0, 0),
                    BookingEnd = new TimeSpan(21, 0, 0),
                    GuestAttending = 4
                },
                new Booking
                {
                    Id = 3,
                    FK_CustomerId = 3,
                    FK_TableId = 3,
                    BookingDate = new DateTime(2024, 11, 7),
                    BookingStart = new TimeSpan(21, 0, 0),
                    BookingEnd = new TimeSpan(22, 0, 0),
                    GuestAttending = 6
                });
        }
    }


}
