using Microsoft.EntityFrameworkCore;
using PetStock.Library.Models;
using PetStock.Library.Service;

namespace PetStock.Library.Data;

/**
 * DbContext com configurações
 */
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<User>? Users { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Shooping>? Shooping { get; set; }
    public DbSet<ShoopingBag>? ShoopingBags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Raca Felina", IconCSS = "fas fa-spa" },
            new Category { CategoryId = 2, Name = "Raca Canina", IconCSS = "fas fa-dog" },
            new Category { CategoryId = 3, Name = "Acessorios", IconCSS = "fas fa-bone" }
        );
        
        modelBuilder.Entity<Product>().HasData(
            // Produtos para Gatos
            new Product { Id = 1, name = "Racao para gato gordo", description = "Racao para gato muito gordo acima dos 10 kilos", ImagemUrl = "", Price = 8.99, Quantity = 100, CategoryId = 1 },
            new Product { Id = 2, name = "Brinquedo interativo para gatos", description = "Brinquedo com luzes e sons para entreter gatos", ImagemUrl = "", Price = 5.99, Quantity = 50, CategoryId = 1 },
            new Product { Id = 3, name = "Colar antipulgas para gatos", description = "Colar eficaz contra pulgas e carrapatos", ImagemUrl = "", Price = 4.99, Quantity = 75, CategoryId = 1 },

            // Produtos para Cães
            new Product { Id = 4, name = "Racao para cachorro adulto", description = "Racao balanceada para cães adultos", ImagemUrl = "", Price = 12.99, Quantity = 80, CategoryId = 2 },
            new Product { Id = 5, name = "Osso de borracha para cães", description = "Osso resistente para mastigar", ImagemUrl = "", Price = 6.99, Quantity = 60, CategoryId = 2 },
            new Product { Id = 6, name = "Shampoo para cães", description = "Shampoo suave para limpeza diária", ImagemUrl = "", Price = 3.99, Quantity = 90, CategoryId = 2 },

            // Acessórios
            new Product { Id = 7, name = "Coleira ajustável", description = "Coleira confortável e ajustável", ImagemUrl = "", Price = 2.99, Quantity = 120, CategoryId = 3 },
            new Product { Id = 8, name = "Casinha para gatos", description = "Casinha aconchegante para gatos", ImagemUrl = "", Price = 19.99, Quantity = 30, CategoryId = 3 },
            new Product { Id = 9, name = "Bolsa para transporte de pets", description = "Bolsa segura e ventilada para transporte", ImagemUrl = "", Price = 14.99, Quantity = 40, CategoryId = 3 }
        );
        
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, UserName = "Saymon Gabriel" },
            new User { Id = 2, UserName = "Ana Silva" },
            new User { Id = 3, UserName = "Carlos Souza" },
            new User { Id = 4, UserName = "Mariana Oliveira" }
        );
    }
    
}