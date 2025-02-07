using System.Collections.ObjectModel;
using Microsoft.VisualBasic;

namespace PetStock.Library.Models;

/**
 * Entidades do banco de dados - Model da Categoria
 */
public class Category
{
     public int CategoryId { get; set; }
     public string Name { get; set; }
     public string IconCSS { get; set; }
     
     public Collection<Product> Products { get; set; } 
          = new Collection<Product>();
}