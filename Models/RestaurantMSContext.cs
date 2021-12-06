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

        public DbSet<Account> Account { get; set; } = null!;
        public DbSet<Employee> Employee { get; set; } = null;
        public DbSet<Manager> Manager { get; set; } = null;
        public DbSet<Driver> Driver { get; set; } = null!; 
    }
}
