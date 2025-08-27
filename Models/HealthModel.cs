using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Models
{
    public class HealthModel
    {
        [Required(ErrorMessage = "Full Name is required.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Mobile No. is required.")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        public string? Gender { get; set; }
    }
}
