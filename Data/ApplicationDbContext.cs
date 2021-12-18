using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantMS.Models;

namespace RestaurantMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RestaurantMS.Models.DeliveryCar> DeliveryCar { get; set; }
        public DbSet<RestaurantMS.Models.Order> Order { get; set; }
        public DbSet<RestaurantMS.Models.Restaurant> Restaurant { get; set; }
        public DbSet<RestaurantMS.Models.Review> Review { get; set; }
        public DbSet<RestaurantMS.Models.Account> Account { get; set; }
        public DbSet<RestaurantMS.Models.Employee> Employee { get; set; }
        public DbSet<RestaurantMS.Models.Manager> Manager { get; set; }
        public DbSet<RestaurantMS.Models.Driver> Driver { get; set; }
        public DbSet<RestaurantMS.Models.Ingredients> Ingredients { get; set; }
        public DbSet<RestaurantMS.Models.DrinkItem> DrinkItem { get; set; }
        public DbSet<RestaurantMS.Models.FoodItem> FoodItem { get; set; }
        public DbSet<RestaurantMS.Models.Menu> Menu { get; set; }
        public DbSet<RestaurantMS.Models.Item> Item { get; set; }
    }
}
