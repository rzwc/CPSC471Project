using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RestaurantMS.Models
{
    public class RestaurantMSContext : DbContext
    {
        public RestaurantMSContext(DbContextOptions<RestaurantMSContext> options)
           : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<DeliveryCar> DeliveryCars { get; set; } = null!;
        public DbSet<DrinkItem> DrinkItems { get; set; } = null!;
        public DbSet<Driver> Drivers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<FoodItem> FoodItems { get; set; } = null!;
        public DbSet<Ingredients> Ingredients { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Menu> Menus { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Restaurant> Restaurants { get; set;} = null!;
        public DbSet<Review> Reviews { get; set; } = null!; 

        
        
    }
}
