using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMS.Models
{
    public class Order
    {
        /// <summary>
        /// Order number.
        /// </summary>
        [Key] public int Order_number { get; set; }
        /// <summary>
        /// ID of driver delivering the order.
        /// </summary>
        [ForeignKey("Driver_ID")] public int Driver_ID { get; set; }
        /// <summary>
        /// ID of customer receiving the order.
        /// </summary>
        [ForeignKey("Customer_ID")] public int Customer_ID { get; set; }
        /// <summary>
        /// Delivery time.
        /// </summary>
        public string Delivery_time { get; set; }
        /// <summary>
        /// Total cost of the order.
        /// </summary>
        public decimal Total_cost { get; set; }
        /// <summary>
        /// Transaction time.
        /// </summary>
        public int Transaction_time { get; set; }

        public Order(int driverID, int customerID, string deliveryTime, decimal totalCost, int transactionTime)
        {
            this.Driver_ID = driverID;
            this.Customer_ID = customerID;
            this.Delivery_time = deliveryTime;
            this.Total_cost = totalCost;
            this.Transaction_time = transactionTime;
        }
    }
}
