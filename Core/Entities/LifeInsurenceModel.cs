using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Core.Entities
{
    public class LifeInsurenceModel
    {
        [Key]
        public int PolicyId { get; set; }
        [Required (ErrorMessage ="Enter Policy Holder Name")]
        [Display (Name = "Policy Holder Name")]
        [Column (TypeName ="varchar(100)")]
        public string? PolicyHolderName { get; set; }
        [Required (ErrorMessage ="Enter Your DOB")]
        [Display (Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required (ErrorMessage ="Click Male Or Female")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Enter your Adderess")]
        [Column(TypeName = "varchar(100)")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Enter your Mobali Number")]
        [Column(TypeName = "varchar(20)")]
        public string? MobailNo { get; set; }
        [Required (ErrorMessage ="Enter Your Email")]
        [Column (TypeName ="varchar(50)")]
        public string? Email { get; set; }
        public string? Pincode { get; set; }
        [Required (ErrorMessage ="Fill Nominee Name")]
        [Display (Name = "Nominee Name")]
        [Column(TypeName = "varchar(50)")]
        public string? NomineeName { get; set; }
        [Required(ErrorMessage = "Fill Nominee Relation")]
        [Display(Name = "Nominee Relation")]
        [Column(TypeName = "varchar(50)")]
        public string? NomineeRelation { get; set; }
        [Required(ErrorMessage = "Fill Policy Start Date")]
        [Display(Name = "Policy Start Date ")]
        public DateTime PolicyStartDate { get; set; }
        [Required(ErrorMessage = "Fill SumAssured")]
        public decimal SumAssured { get; set; }
        [Required(ErrorMessage = "Enter Your Premium")]
        public decimal Premium { get; set; }
        [Required(ErrorMessage = "Enter Your Premium Mode")]
        public string? PremiumMode { get; set; }
        
    }
}
