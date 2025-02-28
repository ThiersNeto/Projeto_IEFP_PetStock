using System.ComponentModel.DataAnnotations;

namespace PetStock.Library.Models;

/**
 * Entidades do banco de dados - Model de cliente
 */
public class User
{
    public int Id { get; set; }
    [MaxLength(100)] public string UserName { get; set; } = string.Empty;
    
    public ShoopingBag? ShoopingBag { get; set; }
}