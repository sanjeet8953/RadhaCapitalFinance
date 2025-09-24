using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Core.Entities
{
    public class CarModel
    {
         [Key]
            public int CarId { get; set; }         

            [Required(ErrorMessage = "Enter Car Name")]
            [StringLength(100)]
            public string? CarName { get; set; }    

            [Required(ErrorMessage = "Enter Car Model")]
            [StringLength(50)]
            public string? Model { get; set; }      

            [Required(ErrorMessage = "Select Car Type")]
            public string? CarType { get; set; }     

            [Required(ErrorMessage = "Enter Registration Number")]
            [StringLength(20)]
            public string? RegistrationNo { get; set; }  

            [Required(ErrorMessage = "Enter Manufacturing Year")]
            public int ManufacturingYear { get; set; } 

            [Required(ErrorMessage = "Enter Fuel Type")]
            public string? FuelType { get; set; }    

            [Required(ErrorMessage = "Enter Seating Capacity")]
            public int SeatingCapacity { get; set; }  // e.g. 5
        [Required(ErrorMessage = "Enter Vehicle Color")]
        public string? Color { get; set; }       // Optional field

            public string? InsurenceType{ get; set; } // Insurance purpose (car value)
        

    }
}
