using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Core.Entities
{
    public class RetirementModel
    {
        [Key]
        public int Id { get; set; }
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
        [Display(Name = "Current Age")]
        public string? Current_Age { get; set; }
        [Required(ErrorMessage = "YearofRetirement is required.")]
        [Display(Name = "Year of Retirement")]
        public string? YearofRetirement { get; set; }
    }
}

