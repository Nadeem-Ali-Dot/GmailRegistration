using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.ViewModel
{
    public class Setp4Model
    {
        [Required(ErrorMessage ="Password is required.")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Password must be at least 8 Character long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$!%*?&])[A-Za-z\d@#$!%*?&]{8,}$",
            ErrorMessage = "Password must include uppercase, lowercase, number, and special character.")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfrimPassword { get; set; } = null!;
        [Display(Name ="Show Password")]
        public bool ShowPassword { get; set; }
    }
}
