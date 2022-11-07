using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_9518_proxy.DTO
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
            Database.Migrate();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Room> rooms = new List<Room>();
            for (int i = 1; i <= 30; i++)
            {
                Random rdn_number = new Random();
                int number = rdn_number.Next(1, 30);
                Random rdn_floor = new Random();
                int floor = rdn_floor.Next(1, 10);
                Random rdn_price = new Random();
                double price = rdn_price.NextDouble();
                Random rdn_aviable = new Random();
                bool isaviable = i % 2 == 1 ? true : false;
                string brief = "brief_" + i.ToString();
                Room room = new Room
                {
                    RoomId = i,
                    RoomNumber = number,
                    Floor = floor,
                    Price = price,
                    Brief = brief,
                    IsAvailable = isaviable
                };
                rooms.Add(room);
            }
            modelBuilder.Entity<Room>().HasData
            (
                rooms
            );
        }
    }
}
