using Microsoft.EntityFrameworkCore;
using PetStockAPI.Models;
using System.Collections.Generic;

namespace PetStockAPI.Data
{
    public class PetStockDbContext : DbContext
    {
        public PetStockDbContext(DbContextOptions<PetStockDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
