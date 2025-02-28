namespace PetStockAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Role { get; set; }

        [ForeignKey("Role")]
        public UserRole? UserRole { get; set; }

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
