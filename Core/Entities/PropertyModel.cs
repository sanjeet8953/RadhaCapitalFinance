using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadhaCapitalFinance.Core.Entities
{
    public class PropertyModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Enter Property Holder Name")]
        [Display (Name = "Property Holder Name")]
        [Column (TypeName = "varchar(100)")]
        public string? PropertyHolderName { get; set; }
        [Required (ErrorMessage ="Enter Your Mobail Number")]
        [Display (Name = "Mobail Number")]
        [Column(TypeName = "varchar(50)")]
        public string? MobailNo { get; set; }
        [Required(ErrorMessage = "Enter Your Property Name")]
        [Display(Name = " Property Name")]
        [Column(TypeName = "varchar(50)")]
        public string? PropertyName { get; set; }
        [Required(ErrorMessage = "Enter Your Property Adderess")]
        [Display(Name = " Property Adderess")]
        [Column(TypeName = "varchar(100)")]
        public string? PropertyAdderess { get; set; }
        [Required(ErrorMessage = "Enter Your Pincode")]
        public int Pincode { get; set; }
        [Required(ErrorMessage = "Enter Your Email")]
        [Column(TypeName = "varchar(100)")]
        public string? Email { get; set; }
        public bool Consent { get; set; }
    }
}
