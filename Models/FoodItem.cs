using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models 
{
    public class FoodItem
    {
        [Key] public int Food_ID { get; set; }
        public int Drink_capacity { get; set; }
        [ForeignKey("Item_ID")] public int Item_ID { get; set; }
    }
}