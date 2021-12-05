using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models
{
    public class Review
    {
        /// <summary>
        /// Review ID.
        /// </summary>
        [Key] public int Review_ID { get; set; }
        /// <summary>
        /// Customer comment.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Customer rating out of 5.
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// Store ID.
        /// </summary>
        [ForeignKey("Store_ID")] public int Store_ID { get; set; }
        /// <summary>
        /// ID of customer who made the review.
        /// </summary>
        [ForeignKey("Customer_ID")] public int Customer_ID { get; set; }

        public Review(int customerID, int storeID, int rating, string comment)
        {
            this.Customer_ID = customerID;
            this.Store_ID = storeID;
            this.Rating = rating;
            this.Comment = comment;
        }

    }
}
