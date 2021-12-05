using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models 
{
    public class FoodItem
    {
        public int Food_ID { get; set; }
        public int Drink_capacity { get; set; }
        [ForeignKey("Item_ID")] public int Item_ID { get; set; }
    }
}