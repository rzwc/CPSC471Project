using System.ComponentModel.DataAnnotations;

namespace CPSC471Project.Models
namespace RestaurantMS.Models
{
    public class Account
    {
        [Key]
        public int Account_Id { get; set; }
        public string? Name { get; set; }
        public string Permission_Type { get; set; }
        public string Password_Hash { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public float Wage { get; set; }
        public int SIN { get; set; }
        public string Position { get; set; }
        public int Manager_ID { get; set; }
    }

    public class Manager
    {
        [Key]
        public int Manager_ID { get; set; }
    }

    public class Driver
    {
        [Key]
        public int Driver_ID { get; set; }
        public string Drivers_License_Number { get; set; }
    }

}