using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Core.Entities
{
    public class LoginModel
    {
      
        public int Id { get; set; }
        [Required(ErrorMessage = "Plese Fill UserId")]
        public string? UserId { get; set; }
        [Required(ErrorMessage = "Plese Fill Password")]
        public string? Password { get; set; }
    }
}
