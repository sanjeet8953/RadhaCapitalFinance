using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Models
{
    public class FireModel
    {
        [Key]
        public int PolicyId { get; set; }
        [Required (ErrorMessage ="Enter Property Holder Name")]
        [Column (TypeName ="varchar(100)")]
        public string? InsuredName { get; set; }
        [Required(ErrorMessage ="Enter Property Address")]
        [Column (TypeName ="varvhar(250)")]
        public string? PropertyAdderess { get; set; }
        [Required(ErrorMessage ="Enter Policy Issue Date")]
        public DateTime PolicyStartDate { get; set; }
        [Required (ErrorMessage = "Fill Expected Money")]
        public decimal SumInsured { get; set; } // BemmaRashi
        [Required (ErrorMessage = "Fill Your affordable premium")]
        public decimal Premium { get; set; }
        public string? PropertyType { get; set; }
       
    }
}
