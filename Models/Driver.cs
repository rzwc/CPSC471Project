using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestaurantMS.Models
{
    public class Driver
    {
        [Key] public int Driver_ID { get; set; }
        public string Drivers_License_Number { get; set; }
        [ForeignKey("Account_Id")] public int Account_Id { get; set; }

    }
}
