using PetStock.Library.Data;
using PetStock.Library.Models;

namespace PetStock.Library.Services;

/**
 * Lógica de negócios - Serviço para gestão de inventário
 */
public class InventoryService
{   
    private readonly AppDbContext _context;

    public InventoryService(AppDbContext context)
    {
        _context = context;
    }
}