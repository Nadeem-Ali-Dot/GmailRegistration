using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.ViewModel
{
    public class Setp7Model
    {
        [EmailAddress(ErrorMessage = "Please enter a valid recovery email address.")]
        [Display(Name = "Recovery Email (Optional)")]
        public string? RecoveryEmail { get; set; }
    }
}
