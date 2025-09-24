using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Core.Entities
{
    public class FireModel
    {
        [Key]
        public int PolicyId { get; set; }
        [Required (ErrorMessage ="Enter Property Holder Name")]
        [Column (TypeName ="varchar(100)")]
        public string? InsuredName { get; set; }
        [Required(ErrorMessage ="Enter Property Address")]
        [Column (TypeName ="varchar(250)")]
        public string? PropertyAdderess { get; set; }
        [Required(ErrorMessage ="Enter Policy Issue Date")]
        public DateTime PolicyStartDate { get; set; }
        [Required (ErrorMessage = "Fill Expected Money")]
        public decimal SumInsured { get; set; } 
        [Required (ErrorMessage = "Enter Your affordable Premium")]
        public decimal Premium { get; set; }
        [Required(ErrorMessage = "Enter Your Property Type")]
        public string? PropertyType { get; set; }
        [Required(ErrorMessage = "Enter Your Pincode")]
        public string? Pincode { get; set; }
       
    }
}
