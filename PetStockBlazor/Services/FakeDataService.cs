using PetStockBlazor.Models;

namespace PetStockBlazor.Services
{
    public class FakeDataService
    {
        private List<Category> categories;
        private List<Product> products;
        private List<Client> clients;
        private List<StockMovement> stockMovements;

        public FakeDataService()
        {
            // Dados fictícios
            categories = new List<Category>
            {
                new Category { Id = 1, Name = "Ração" },
                new Category { Id = 2, Name = "Brinquedos" },
                new Category { Id = 3, Name = "Petiscos" },
                new Category { Id = 4, Name = "Roupas" },
                new Category { Id = 5, Name = "Tratamentos" }

            };

            products = new List<Product>
            {
                new Product { Id = 1, Name = "Ração Para Cão Adulto", Description = "Ração Balance Frango, 7kg.", Price = 55, StockQuantity = 10, CategoryId = 1, Category = categories[0], ImageUrl = "/images/Ração Adulto.jpg" },
                new Product { Id = 2, Name = "Ração Para Cão Sênior", Description = "Ração Para Cão Sênior Carne e Arroz, 3kg.", Price = 25, StockQuantity = 7, CategoryId = 1, Category = categories[0], ImageUrl = "/images/Ração Sênior.jpg" },
                new Product { Id = 3, Name = "Ração Para Cão Júnior", Description = "Ração para Cão Júnior Frango e Legumes, 1,5Kg.", Price = 15, StockQuantity = 12, CategoryId = 1, Category = categories[0], ImageUrl = "/images/Ração Júnior.jpg" },
                new Product { Id = 4, Name = "Osso de Borracha", Description = "Brinquedo Para Cão, Osso de Borracha Vermelho.", Price = 15, StockQuantity = 20, CategoryId = 2, Category = categories[1], ImageUrl = "/images/Osso Borracha.jpg" },
                new Product { Id = 5, Name = "Disco para Cão", Description = "Brinquedo Para Cão Disco de 21cm.", Price = 5, StockQuantity = 8, CategoryId = 2, Category = categories[1], ImageUrl = "/images/Dico Cão.jpg" },
                new Product { Id = 6, Name = "Bola de Borracha", Description = "Brinquedo Para Cão Bola de Borracha Laranja.", Price = 4, StockQuantity = 25, CategoryId = 2, Category = categories[1], ImageUrl = "/images/Bola Borracha.jpg" },
                new Product { Id = 7, Name = "Peluche Donuts", Description = "Brinquedo Para Cão Peluche Formato Donuts 20cm.", Price = 12, StockQuantity = 10, CategoryId = 2, Category = categories[1], ImageUrl = "/images/Peluche Donuts.jpg" },
                new Product { Id = 8, Name = "Tiras de Carne", Description = "Tiras para Cão, Sabor Carne.", Price = 2, StockQuantity = 10, CategoryId = 3, Category = categories[2], ImageUrl = "/images/Tiras de carne.jpg" },
                new Product { Id = 9, Name = "Stick Dentário", Description = "Snack Higiene Oral Diária.", Price = 2.69m, StockQuantity = 15, CategoryId = 3, Category = categories[2], ImageUrl = "/images/Stick Dentário.jpg" },
                new Product { Id = 10, Name = "Snack Ossinhos", Description = "Snack para Cão Adulto de Ossinhos, Sabor Carne.", Price = 1.99m, StockQuantity = 25, CategoryId = 3, Category = categories[2], ImageUrl = "/images/Snack Ossinhos.jpg" },
                new Product { Id = 11, Name = "Hoodie Cão Páscoa", Description = "Hoodie para Cão Páscoa, 20cm.", Price = 10.69m, StockQuantity = 5, CategoryId = 4, Category = categories[3], ImageUrl = "/images/Hoodie Páscoa.jpg" },
                new Product { Id = 12, Name = "Camisola Cão", Description = "Camisola Polar Estrelas, 25cm.", Price = 8.99m, StockQuantity = 12, CategoryId = 4, Category = categories[3], ImageUrl = "/images/Camisola.jpg" },
                new Product { Id = 13, Name = "Capa Impermeável para Cão", Description = "Capa vermelha, 30cm.", Price = 16.49m, StockQuantity = 8, CategoryId = 4, Category = categories[3], ImageUrl = "/images/Capa Chuva.jpg" },
                new Product { Id = 14, Name = "Champô para Cão", Description = "Champô para Cão Uso Frequente.", Price = 4.90m, StockQuantity = 20, CategoryId = 5, Category = categories[4], ImageUrl = "/images/Champô para Cão.jpg" },
                new Product { Id = 15, Name = "Alicate de Unhas", Description = "Alicate de Unhas para Cão.", Price = 3.99m, StockQuantity = 10, CategoryId = 5, Category = categories[4], ImageUrl = "/images/Alicate de Unhas.jpg" },
                new Product { Id = 16, Name = "Coleira Repelente", Description = "Coleira repelente para cães.", Price = 6.99m, StockQuantity = 13, CategoryId = 5, Category = categories[4], ImageUrl = "/images/Coleira Repelente.jpg" },
            };

            clients = new List<Client>
            {
                new Client { Id = 1, Name = "João Silva", Email = "joao@email.com" },
                new Client { Id = 2, Name = "Maria Oliveira", Email = "maria@email.com" }
            };

            stockMovements = new List<StockMovement>
            {
                new StockMovement { ProductId = 1, Quantity = 5, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-10) },
                new StockMovement { ProductId = 1, Quantity = 5, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-10) },
                new StockMovement { ProductId = 1, Quantity = 3, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-8) },
                new StockMovement { ProductId = 1, Quantity = 4, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-6) },
                new StockMovement { ProductId = 1, Quantity = 2, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-4) },
                new StockMovement { ProductId = 1, Quantity = 1, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-2) },

                // Ração Para Cão Sênior
                 new StockMovement { ProductId = 2, Quantity = 7, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-9) },
                 new StockMovement { ProductId = 2, Quantity = 5, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-7) },
                 new StockMovement { ProductId = 2, Quantity = 3, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-5) },
                 new StockMovement { ProductId = 2, Quantity = 2, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 2, Quantity = 1, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-1) },

                 // Movimentações Cão Júnior
                 new StockMovement { ProductId = 3, Quantity = 10, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-12) },
                 new StockMovement { ProductId = 3, Quantity = 5, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-10) },
                 new StockMovement { ProductId = 3, Quantity = 5, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-10) },
                 new StockMovement { ProductId = 3, Quantity = 3, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 3, Quantity = 2, Type = "Saída", Description = "Ajuste de estoque - Produto vencido", Date = DateTime.Now.AddDays(-4) },

                 // Osso de Borracha
                 new StockMovement { ProductId = 4, Quantity = 15, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-5) },
                 new StockMovement { ProductId = 4, Quantity = 8, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-4) },
                 new StockMovement { ProductId = 4, Quantity = 6, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 4, Quantity = 4, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-2) },
                 new StockMovement { ProductId = 4, Quantity = 3, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-1) },

                 //Disco para Cão
                 new StockMovement { ProductId = 5, Quantity = 10, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 5, Quantity = 4, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-5) },
                 new StockMovement { ProductId = 5, Quantity = 6, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 5, Quantity = 5, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-2) },
                 new StockMovement { ProductId = 5, Quantity = 2, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-1) },

                 // Bola de Borracha
                 new StockMovement { ProductId = 6, Quantity = 20, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-15) },
                 new StockMovement { ProductId = 6, Quantity = 10, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-14) },
                 new StockMovement { ProductId = 6, Quantity = 12, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-12) },
                 new StockMovement { ProductId = 6, Quantity = 7, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-10) },
                 new StockMovement { ProductId = 6, Quantity = 3, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-8) },

                 // Peluche Donuts
                 new StockMovement { ProductId = 7, Quantity = 10, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-8) },
                 new StockMovement { ProductId = 7, Quantity = 6, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-7) },
                 new StockMovement { ProductId = 7, Quantity = 8, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 7, Quantity = 5, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-5) },
                 new StockMovement { ProductId = 7, Quantity = 2, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-4) },

                 // Tiras de Carne
                 new StockMovement { ProductId = 8, Quantity = 15, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 8, Quantity = 5, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-2) },
                 new StockMovement { ProductId = 8, Quantity = 7, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-1) },
                 new StockMovement { ProductId = 8, Quantity = 3, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(0) },
                 new StockMovement { ProductId = 8, Quantity = 1, Type = "Saída", Description = "Ajuste de estoque - Produto vencido", Date = DateTime.Now.AddDays(1) },

                 // Stick Dentário
                 new StockMovement { ProductId = 9, Quantity = 20, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-5) },
                 new StockMovement { ProductId = 9, Quantity = 10, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-4) },
                 new StockMovement { ProductId = 9, Quantity = 12, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 9, Quantity = 7, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-2) },
                 new StockMovement { ProductId = 9, Quantity = 3, Type = "Saída", Description = "Ajuste de estoque - Produto vencido", Date = DateTime.Now.AddDays(-1) },

                 // Champô
                 new StockMovement { ProductId = 14, Quantity = 10, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-15) },
                 new StockMovement { ProductId = 14, Quantity = 5, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-12) },
                 new StockMovement { ProductId = 14, Quantity = 8, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-9) },
                 new StockMovement { ProductId = 14, Quantity = 3, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 14, Quantity = 2, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-3) },

                 // Alicate Unhas
                 new StockMovement { ProductId = 15, Quantity = 20, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-10) },
                 new StockMovement { ProductId = 15, Quantity = 12, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-8) },
                 new StockMovement { ProductId = 15, Quantity = 15, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 15, Quantity = 7, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-4) },
                 new StockMovement { ProductId = 15, Quantity = 3, Type = "Saída", Description = "Ajuste de estoque - Produto danificado", Date = DateTime.Now.AddDays(-2) },

                 // Coleira Repelente
                 new StockMovement { ProductId = 16, Quantity = 15, Type = "Entrada", Description = "Compra de fornecedores", Date = DateTime.Now.AddDays(-7) },
                 new StockMovement { ProductId = 16, Quantity = 8, Type = "Saída", Description = "Venda para cliente João Silva", Date = DateTime.Now.AddDays(-6) },
                 new StockMovement { ProductId = 16, Quantity = 10, Type = "Entrada", Description = "Reposição de estoque", Date = DateTime.Now.AddDays(-4) },
                 new StockMovement { ProductId = 16, Quantity = 6, Type = "Saída", Description = "Venda para cliente Maria Oliveira", Date = DateTime.Now.AddDays(-3) },
                 new StockMovement { ProductId = 16, Quantity = 4, Type = "Saída", Description = "Ajuste de estoque - Produto vencido", Date = DateTime.Now.AddDays(-1) },
            };




        }

        public List<StockMovement> GetStockMovementsForProduct(int productId)
        {
            return stockMovements.Where(sm => sm.ProductId == productId).ToList();
        }

        public List<Product> GetProducts()
        {
            return products.Where(p => !p.IsDeleted).ToList();
        }
        public List<Category> GetCategories()
        {
            return categories.Where(c => !c.IsDeleted).ToList();
        }
        public List<Client> GetClients() => clients;

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }

        public void SoftDeleteProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.IsDeleted = true;
            }
        }

        public void SoftDeleteCategory(int categoryId)
        {
            var category = categories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null)
            {
                category.IsDeleted = true;
            }
        }

        public void RegisterStockMovement(StockMovement movement)
        {
            
            var product = products.FirstOrDefault(p => p.Id == movement.ProductId);
            if (product != null)
            {
                product.StockMovements.Add(movement);

                if (movement.Type == "Entrada")
                {
                    product.StockQuantity += movement.Quantity;
                }
                else if (movement.Type == "Saída")
                {
                    if (product.StockQuantity >= movement.Quantity)
                    {
                        product.StockQuantity -= movement.Quantity;
                    }
                    else
                    {
                        throw new InvalidOperationException("Estoque insuficiente para realizar a saída.");
                    }
                }

                
                stockMovements.Add(movement);
            }
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.StockQuantity = product.StockQuantity;
            }
        }

    }
}

