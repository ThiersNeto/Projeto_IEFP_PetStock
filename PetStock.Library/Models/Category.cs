namespace PetStock.Library.Models;

/**
 * Entidades do banco de dados - Model da Categoria
 */
public class Category
{
     public int Id { get; set; }
     public string Name { get; set; }
     public bool IsDeleted { get; set; } = false;
     public List<Product> Products { get; set; } = new List<Product>();
}