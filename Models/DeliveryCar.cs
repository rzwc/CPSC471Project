using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models
{
    public class DeliveryCar
    {
        /// <summary>
        /// License plate of the car.
        /// </summary>
        [Key] public string License_plate { get; set; }
        /// <summary>
        /// Car mileage.
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// Car colour.
        /// </summary>
        public string Car_colour { get; set; }
        /// <summary>
        /// Car model.
        /// </summary>
        public string Car_model { get; set; }
        /// <summary>
        /// True if car is currently in service.
        /// </summary>
        public bool Is_active { get; set; }
        /// <summary>
        /// Longitude of car location.
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// Latitude of car location.
        /// </summary>
        public decimal Latitude { get; set; }

        public DeliveryCar(string licensePlate, int mileage, string carColour, string carModel, bool isActive, decimal longitude, decimal latitude)
        {
            this.License_plate = licensePlate;
            this.Mileage = mileage;
            this.Car_colour = carColour;
            this.Car_model = carModel;
            this.Is_active = isActive;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }
    }
}
