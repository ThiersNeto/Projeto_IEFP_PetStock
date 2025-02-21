using PetStockBlazor.Models;

namespace PetStockBlazor.Services
{
    public class FakeDataService
    {
        private List<Category> categories;
        private List<Product> products;
        private List<Client> clients;

        public FakeDataService()
        {
            // Dados fictícios
            categories = new List<Category>
            {
                new Category { Id = 1, Name = "Ração" },
                new Category { Id = 2, Name = "Brinquedos" }
            };

            products = new List<Product>
            {
                new Product { Id = 1, Name = "Ração Premium", Price = 79.99m, StockQuantity = 10, CategoryId = 1, Category = categories[0] },
                new Product { Id = 2, Name = "Osso de Borracha", Price = 15.50m, StockQuantity = 20, CategoryId = 2, Category = categories[1] }
            };

            clients = new List<Client>
            {
                new Client { Id = 1, Name = "João Silva", Email = "joao@email.com" },
                new Client { Id = 2, Name = "Maria Oliveira", Email = "maria@email.com" }
            };
        }

        public List<Product> GetProducts() => products;
        public List<Category> GetCategories() => categories;
        public List<Client> GetClients() => clients;

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }
    }
}

