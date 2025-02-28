using PetStockAPI.Models;

namespace PetStockAPI.Data
{
    public static class DataSeeder
    {
        public static void Seed(PetStockDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                    {
                        new Category { Name = "Ração" },
                        new Category { Name = "Brinquedos" },
                        new Category { Name = "Petiscos" },
                        new Category { Name = "Roupas" },
                        new Category { Name = "Tratamentos" }
                    };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                var racao = context.Categories.FirstOrDefault(c => c.Name == "Ração");
                var brinquedos = context.Categories.FirstOrDefault(c => c.Name == "Brinquedos");

                var products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ração Para Cão Adulto",
                            Description = "Ração Balance Frango, 7kg.",
                            Price = 55,
                            StockQuantity = 10,
                            CategoryId = racao.Id,
                            ImageUrl = "images/RaçãoAdulto.jpg"
                        },
                        new Product
                        {
                            Name = "Osso de Borracha",
                            Description = "Brinquedo Para Cão, Osso de Borracha Vermelho.",
                            Price = 15,
                            StockQuantity = 20,
                            CategoryId = brinquedos.Id,
                            ImageUrl = "/images/OssoBorracha.jpg"
                        }
                    };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
