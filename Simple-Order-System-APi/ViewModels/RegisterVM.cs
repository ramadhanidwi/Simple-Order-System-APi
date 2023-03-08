using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_Order_System_APi.ViewModels
{
    public class RegisterVM
    {
        public string Id { get; set; }

        [Display(Name = "Office Code")]
        public int OfficeCode { get; set; }

        [Display(Name = "Reports To")]

        public int? ReportsTo { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
