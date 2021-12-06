using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models 
{
    public class Ingredients
    {
        [Key] public string Name { get; set; }
        public float Cost { get; set; }
        public int Calories { get; set; }
    }
}