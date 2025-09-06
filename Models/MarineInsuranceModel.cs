using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Models
{
    public class MarineInsuranceModel
    {
        [Key]
        public int PolicyId { get; set; }   

        [Required(ErrorMessage = "Enter Policy Holder Name")]
        [StringLength(150)]
        [Display(Name = "Policy Holder Name")]
        public string? PolicyHolderName { get; set; }  

        [Required(ErrorMessage = "Enter Cargo Description")]
        [StringLength(250)]
        [Display (Name = "Cargo Description") ]
        
        public string? CargoDescription { get; set; }   

        [Required(ErrorMessage = "Enter Departure Port")]
        [StringLength(150)]
        [Display (Name = "Departure Port")]
        public string? DeparturePort { get; set; }   

        [Required(ErrorMessage = "Enter Destination Port")]
        [StringLength(150)]
        [Display(Name = "Destination Port")]
        public string? DestinationPort { get; set; }  

        [Required(ErrorMessage = "Enter Departure Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }   

        [Required(ErrorMessage = "Enter Expected Arrival Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Arrival Date")]
        public DateTime ArrivalDate { get; set; }  

        [Required(ErrorMessage = "Enter Transport Mode")]
        [StringLength(50)]
        [Display (Name = "Transport Mode")]
        public string? TransportMode { get; set; }   

        [Required(ErrorMessage = "Enter Sum Insured")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Sum Insured")]
        public decimal SumInsured { get; set; }   
        [Required(ErrorMessage = "Enter Premium Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Premium { get; set; }   

        [Required(ErrorMessage = "Enter Risk Coverage")]
        [Display(Name = "Risk Coverage")]
        public string? RiskCoverage { get; set; }   
    }

}
