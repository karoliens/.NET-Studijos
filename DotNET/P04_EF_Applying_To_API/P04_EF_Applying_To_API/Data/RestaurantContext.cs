﻿using Microsoft.EntityFrameworkCore;
using P04_EF_Applying_To_API.Models;

namespace P04_EF_Applying_To_API.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
            
        }

        // Registruojamos lenteles
        // Prop pavadinimas = Lenteles pavadinimas
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<RecipeItem> RecipeItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data-seeding
            modelBuilder.Entity<Dish>()
                .HasData(
                new Dish(1, "Fried Bread Sticks", "Snacks", "Mild", "Lithuanian", "", DateTime.Now),
                new Dish(2, "Potato dumplings", "Main dish", "Low", "Lithuanian", "", DateTime.Now),
                new Dish(3, "Kibinai", "Street food", "Low", "Lithuanian", "", DateTime.Now)
                );
            modelBuilder.Entity<RecipeItem>()
                .HasData(
                new RecipeItem(1, "Bread", 150, 1),
                new RecipeItem(2, "Cheese", 300, 1),
                new RecipeItem(3, "Mayo", 300, 1),
                new RecipeItem(4, "Garlic", 50, 1),
                new RecipeItem(5, "Potatoes", 400, 2),
                new RecipeItem(6, "Meat", 400, 2),
                new RecipeItem(7, "Sour Cream", 300, 2),
                new RecipeItem(8, "Dough", 300, 3),
                new RecipeItem(9, "Meat", 200, 3),
                new RecipeItem(10, "Salt", 150, 3)
                );
        }
    }
}
