using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Final_Project.Data
{
    public class RepairShopContext : DbContext
    {
        public RepairShopContext(DbContextOptions<RepairShopContext> options) : base(options)
        { 
        
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasData(
                new Ticket (1, "karoliens@gmail.com", "", "Repair", "", DateTime.Now),
                new Ticket (2, "ievuzis@gmail.com", "", "Data Recovery", "", DateTime.Now),
                new Ticket (3, "tomukas@gmail.com", "", "Repair", "", DateTime.Now),
                new Ticket (4, "sauliens@gmail.com", "",  "Repair", "", DateTime.Now)
                );

            modelBuilder.Entity<User>()
                .HasData(
                new User (1, "karoliens", "Karolis", 1),
                new User (2, "ievuzis", "Ieva", 2),
                new User (3, "tomukas", "Tomas", 3),
                new User (4, "sauliens","Saulius", 4)
                );
        }
    }
}
