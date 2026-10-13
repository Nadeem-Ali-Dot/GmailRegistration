using GmailRegistration.Models;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.ViewModel
{
    public class Setp2Model
    {
        [Required(ErrorMessage ="Month is required.")]
        public string Month { get; set; } = null!;

        [Required(ErrorMessage = "Day is required.")]
        [Range(1,31,ErrorMessage ="Please enter a valid day.")]
        public int Day { get; set; } 

        [Required(ErrorMessage = "Year is required.")]
        [Range(1900, 2100, ErrorMessage = "Please enter a valid Year.")]
        public int Year { get; set; } 

        [Required(ErrorMessage ="Gender is required.")]
        public Gender Gender { get; set; }

    //    public IEnumerable<ValidationResult> Validate (ValidationContext validationContext)
    //    {
    //        var datestring = $"{Month} {Day},{Year}";
    //        if (DateTime.TryParse(datestring, out var dob))
    //        {
    //            yield return new ValidationResult("Date of birth is invalid");
    //        }
    //        else
    //        {
    //            var today = DateTime.Today;
    //            var age = today.Year - dob.Year;

    //            if (dob > today.AddYears(-age)) age--;
    //            if (age < 13)
    //            {
    //                yield return new ValidationResult("You must be at least 13 yeras old", new[] { nameof(Day),nameof(Month),nameof(Year)});
    //            }
    //        }

    //    }
    }
}
