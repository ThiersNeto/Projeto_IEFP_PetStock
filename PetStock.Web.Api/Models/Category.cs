using System.ComponentModel.DataAnnotations;

namespace PetStockAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        // Caso você deseje usar categorias pai, pode usar:
        public int? ParentCategoryId { get; set; }

        public string IconCSS { get; set; } = string.Empty;
    }
}
