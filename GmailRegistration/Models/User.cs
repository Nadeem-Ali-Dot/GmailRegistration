using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required, StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Required, StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
       public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string CountryCode { get; set; } = null!;
        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [EmailAddress]
        public string? RecoveryEmail { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;


    }
}
