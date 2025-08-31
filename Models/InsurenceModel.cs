using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Models
{
    public class FinanceModel
    {
        [Required(ErrorMessage = "Select a product")]
        public string? Product { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Required]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter your mobile number")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter valid 10 digit mobile number")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "You must agree to Terms & Conditions")]
        public bool Consent { get; set; }
    }
}
