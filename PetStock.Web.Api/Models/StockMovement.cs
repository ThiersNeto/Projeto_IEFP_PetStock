using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStockAPI.Models
{
    public class StockMovement
    {
        [Key]
        public int Id { get; set; } // Chave para o EF Core

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public string Type { get; set; }  // \"Entrada\" ou \"Saída\"
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public StockMovement() { }

        public StockMovement(int productId, string type, string description, int quantity)
        {
            ProductId = productId;
            Type = type;
            Description = description;
            Quantity = quantity;
            Date = DateTime.Now;
        }
    }
}
