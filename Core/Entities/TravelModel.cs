using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Core.Entities
{
    public class TravelModel
    {
        [Key]
        public int TravelId { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Enter your Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Enter your Mobail Number")]
        public string? MobailNo { get; set; }
        [Column(TypeName ="varchar(60)")]
        [Required(ErrorMessage = "Enter your Email ")]
        public string? Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Enter your Adderess ")]
        public string? Adderess { get; set; }
        [Required(ErrorMessage ="Enter No Off Member")]
        [Display (Name = "Total Member")]
        public int TotalMembers { get; set; }
        [Required(ErrorMessage = "Enter Departure")]
        [Display(Name = "Date of Departure")]
        public int DateofDeparture { get; set; }
        [Required(ErrorMessage = "Enter Arrival Date")]
        [Display(Name = "Date of Arrival")]
        public int DateofArrival { get; set; }
        public string? Gender { get; set; }
    }
}
