using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models
{
    public class Manager
    {
        [Key] public int Manager_ID { get; set; }

        [ForeignKey("Account_Id")] public int Account_Id { get; set; }
    }
}
