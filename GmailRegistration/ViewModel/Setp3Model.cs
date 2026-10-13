using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.ViewModel
{
    public class Setp3Model
    {
        [Required(ErrorMessage ="Gmail Address is required.")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address.")]
        public string Email { get; set; } = null!;
        public List<string> SuggestedEmails { get; set; } = new List<string>();
        public string? SuggestedEmail { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? CustomEmail { get; set; }

    }
}
