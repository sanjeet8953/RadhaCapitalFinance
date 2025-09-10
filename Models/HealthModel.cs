using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Models
{
    public class HealthModel
    {
        [Required(ErrorMessage = "Enter Your Name.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Enter Your Mobail Number")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Chose InsurenceType")]
        public string? InsurenceType { get; set; }
      
        [Required(ErrorMessage = "Enter Your DOB")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Enter Your Pincode")]
        public int Pincode { get; set; }
        [Required(ErrorMessage = "Enter Your Gender")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Enter Your NoOffPeople")]
        [Display(Name = "No Off People")]
        public int NoOffPeople { get; set; }
    }
}
