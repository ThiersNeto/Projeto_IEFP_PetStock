using System.ComponentModel.DataAnnotations;

namespace PetStockBlazor.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress, StringLength(150)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
