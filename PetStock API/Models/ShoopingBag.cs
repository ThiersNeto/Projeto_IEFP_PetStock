using PetStock.Library.Service;
using PetStockBlazor.Models;

namespace PetStock.Library.Models;

public class ShoopingBag
{
    public int Id { get; set; }
    public int ShoppingId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Product Product { get; set; }
    public Shooping Shopping { get; set; }
}