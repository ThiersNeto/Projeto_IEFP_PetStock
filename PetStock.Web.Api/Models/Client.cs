using System.ComponentModel.DataAnnotations;

namespace PetStockAPI.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [StringLength(255)]
        public string Address { get; set; } = string.Empty;

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
