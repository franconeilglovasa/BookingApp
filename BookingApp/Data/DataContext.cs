using BookingApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BookingApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingId = 1,
                    PassengerName = "BenKen",
                    Date = "9/10/2024",
                    Time = "10:00 AM",
                    PickupLocation = "NU Baliwag",
                    DropoffLocation = "Boss R",
                    Distance = 10.0f,
                    Fare = 205.0f
                }
            );
        }
    }
}
