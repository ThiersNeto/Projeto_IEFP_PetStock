using System.ComponentModel.DataAnnotations;

namespace PetStockBlazor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public bool SoftDelete { get; set; } = false;
    }
}
