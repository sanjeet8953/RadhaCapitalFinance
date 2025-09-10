using System.ComponentModel.DataAnnotations;

namespace RadhaCapitalFinance.Core.Entities
{
    public class SIPModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MobailNo { get; set; }
        public string? Email { get; set; }
        public string? Adderess { get; set; }
        public string? Gender { get; set; }
    }
}
