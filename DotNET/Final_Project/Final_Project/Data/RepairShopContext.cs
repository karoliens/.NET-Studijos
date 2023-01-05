using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class RepairShopContext : DbContext
    {
        // Registruojamos lenteles
        // Prop pavadinimas = Lenteles pavadinimas
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data-seeding
            modelBuilder.Entity<User>()
                .HasData(
                new User(1, "", ""),
                new User(2, "", ""),
                new User(3, "", "")
                );
            modelBuilder.Entity<Ticket>()
                .HasData(
                new Ticket(1, ""),
                new Ticket(2, ""),
                new Ticket(3, "")
                );
        }
    }
}
