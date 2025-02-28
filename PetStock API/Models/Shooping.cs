using PetStock.Library.Models;

namespace PetStock.Library.Service;

/**
 * Entidades do banco de dados - Model de service.
 */
public class Shooping
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<ShoopingBag> Items { get; set; }
    
    public ICollection<ShoopingBag> Itens { get; set; }
        = new List<ShoopingBag>();
}