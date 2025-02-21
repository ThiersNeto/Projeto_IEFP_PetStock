using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetStockBlazor.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        public DateTime SaleDate { get; set; } = DateTime.Now;

        [Required]
        public decimal Total { get; set; }

        public bool SoftDelete { get; set; } = false;
    }
}
