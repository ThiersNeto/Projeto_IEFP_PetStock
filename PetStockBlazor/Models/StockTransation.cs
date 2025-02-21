using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetStockBlazor.Models
{
    public class StockTransation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [Required, StringLength(10)]
        public string Type { get; set; } = string.Empty;// 'Entrance' ou 'Exit'

        [Required]
        public int Quantity { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
