using System.ComponentModel.DataAnnotations;

namespace RestaurantMS.Models
{
    public class Account
    {
        [Key] public int Account_Id { get; set; }
        public string? Name { get; set; }
        public string Permission_Type { get; set; }
        public string Password_Hash { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
