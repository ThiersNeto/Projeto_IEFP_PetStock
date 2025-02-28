﻿
namespace PetStockAPI.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
