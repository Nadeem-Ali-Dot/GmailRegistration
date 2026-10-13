using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.Models
{
    public class RegistrationSession
    {
        [Key]
        public Guid RegistrationId { get; set; } = Guid.NewGuid();
        public string? Email { get; set; }
        public string? Password { get; set; }        
        public string? FirstName { get; set; }     
        public string? LastName { get; set; } 
        public DateTime? DateOfBirth { get; set; }     
        public Gender? Gender { get; set; }       
        public string ?CountryCode { get; set; }         
        public string? PhoneNumber { get; set; }      
        public string? RecoveryEmail { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; } 
    }
}
