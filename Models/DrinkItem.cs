using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models 
{
    public class DrinkItem
    {
        public int Drink_ID { get; set; }
        public int Drink_capacity { get; set; }
        [ForeignKey("Item_ID")] public int Item_ID { get; set; }
    }
}