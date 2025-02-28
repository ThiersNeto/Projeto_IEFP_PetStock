using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStockAPI.Models
{
    public class Product
    {
        public string ImagemUrl { get; set; } = string.Empty;
        public int Quantity { get; set; }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(255)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        public List<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
    }
}
