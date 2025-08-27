using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Models
{
    public class RetirementModel
    {
        [Required(ErrorMessage = "Full Name is required.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Mobile No. is required.")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "PinCode is required.")]
        public string? Pincode { get; set; }
        [Required(ErrorMessage = "CurrentAge is required.")]
        public string? Current_Age { get; set; }
        [Required(ErrorMessage = "YearofRetirement is required.")]
        public string? YearofRetirement { get; set; }
    }
}

