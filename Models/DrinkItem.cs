using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models 
{
    public class DrinkItem
    {
        [Key] public int Drink_ID { get; set; }
        public int Drink_capacity { get; set; }
        [ForeignKey("Item_ID")] public int Item_ID { get; set; }
    }
}