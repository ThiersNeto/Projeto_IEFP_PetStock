namespace PetStock.Library.Models;

/**
 * Entidades do banco de dados - Model de Produtos
 */
public class Product
{
    public int Id { get; set; }
    public int StockQuantity { get; set; }
    public int CategoryId { get; set; }
    public bool isDeleted { get; set; } = false; 
    public string name { get; set; }
    public string description { get; set; }
    public decimal costPrice { get; set; }
    public Category Category { get; set; }
}