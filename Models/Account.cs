using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Store_ID")] public int Store_ID { get; set; }
    }
}
