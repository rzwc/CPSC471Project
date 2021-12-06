using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models 
{
    public class Item
    {
        [Key] public int Item_ID { get; set; }
        public string Size { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        [ForeignKey("Menu_Name")] public string Menu_Name { get; set; }
    }
}