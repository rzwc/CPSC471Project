using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models
{
    public class Restaurant
    {
        /// <summary>
        /// Store ID.
        /// </summary>
        [Key] public int Store_ID { get; set; }
        /// <summary>
        /// Time when the restaurant opens.
        /// </summary>
        public string Start_Time { get; set; }
        /// <summary>
        /// Closing time.
        /// </summary>
        public string End_Time { get; set; }
        /// <summary>
        /// Address of restaurant.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Delivery radius from restaurant address.
        /// </summary>
        public int Delivery_range { get; set; }
    }
}
