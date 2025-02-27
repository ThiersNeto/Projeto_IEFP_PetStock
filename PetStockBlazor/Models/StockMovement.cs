namespace PetStockBlazor.Models
{
    public class StockMovement
    {
        public int ProductId { get; set; }
        public string Type { get; set; }  // "Entrada" ou "Saída"
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
