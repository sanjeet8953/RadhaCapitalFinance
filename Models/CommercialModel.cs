using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Models
{
    public class CommercialModel
    {
        [Key]
        public int PolicyId { get; set; }   

        [Required(ErrorMessage = "Enter Business/Company Name")]
        [StringLength(200)]
        [Display ( Name ="Businame Name")]
        public string? BusinessName { get; set; }  

        [Required(ErrorMessage = "Enter Business Type")]
        [StringLength(100)]
        [Display(Name = "Businame Name")]
        public string? BusinessType { get; set; }   

        [Required(ErrorMessage = "Enter Address")]
        [StringLength(250)]
        public string? Address { get; set; } 
       
        [Required(ErrorMessage = "Enter Mobile Number")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter valid 10 digit mobile number")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Enter Email ID")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter Policy Start Date")]
        [DataType(DataType.Date)]
        public DateTime PolicyStartDate { get; set; }

        [Required(ErrorMessage = "Enter Policy End Date")]
        [DataType(DataType.Date)]
        public DateTime PolicyEndDate { get; set; }

        [Required(ErrorMessage = "Enter Sum Insured")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SumInsured { get; set; }   

        [Required(ErrorMessage = "Enter Premium Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Premium { get; set; }   
    }
}
