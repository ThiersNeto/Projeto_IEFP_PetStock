using PetStock.Library.Models;

namespace PetStock.Library.Service;

/**
 * Entidades do banco de dados - Model de service.
 */
public class Service
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public Client Client { get; set; }
    public DateTime OccurrenceDate { get; set; }
}