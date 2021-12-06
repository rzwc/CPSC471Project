using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models
{
    public class Employee
    {
        [Key] public int Employee_Id { get; set; }
        public float Wage { get; set; }
        public int SIN { get; set; }
        public string Position { get; set; }
        public int Manager_ID { get; set; }

        [ForeignKey("Account_Id")] public int Account_Id { get; set; }
    }
}
