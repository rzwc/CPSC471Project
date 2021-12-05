using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models 
{
    public class Menu
    {
        [Key] public string Menu_Name { get; set; }
        public DateTime? Last_Updated { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        [ForeignKey("Store_ID")] public int Store_ID { get; set; }
    }
}