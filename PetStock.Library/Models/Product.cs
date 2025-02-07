using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetStock.Library.Models;

/**
 * Entidades do banco de dados - Model de Produtos
 */
public class Product
{
    public int Id { get; set; }
    
    [MaxLength(100)] public string name { get; set; }
    [MaxLength(200)] public string description { get; set; }
    [MaxLength(200)] public string ImagemUrl { get; set; }
    [Column(TypeName = "decimal(10, 2)")] public double Price { get; set; }
    public int Quantity { get; set; }
    public int CategoryId { get; set; }
    public bool IsDeleted { get; set; }
    public Category? Category { get; set; }
    
    
    public ICollection<ShoopingBag> ShoopingBags { get; set; }
        = new List<ShoopingBag>();
}