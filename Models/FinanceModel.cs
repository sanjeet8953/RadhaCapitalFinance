using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Models
{
    public class FinanceModel
    {
        [Column(TypeName= "varchar(100)")]
        [Required(ErrorMessage = "Select a product")]
        public string? Product { get; set; }
        [Column(TypeName = "varchar(100)")]

        [Required(ErrorMessage = "Enter your name")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(100)")]

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Required]
        public string? Email { get; set; }
        [Column(TypeName = "varchar(20)")]

        [Required(ErrorMessage = "Enter your mobile number")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter valid 10 digit mobile number")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "You must agree to Terms & Conditions")]
        public bool Consent { get; set; }
    }
}
