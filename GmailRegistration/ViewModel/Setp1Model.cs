using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.ViewModel
{
    public class Setp1Model
    {
        [Required(ErrorMessage ="First Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$",ErrorMessage ="First name must contain only character.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must contain only character.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = null!;
    }
}
