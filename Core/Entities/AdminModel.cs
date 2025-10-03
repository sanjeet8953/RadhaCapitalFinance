namespace RadhaCapitalFinance.Core.Entities
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string? AdminName { get; set; }
        public DateTime DOB { get; set; }
        public  string? Gender { get; set; }
        public string?  MobailNo { get; set; }
        public string?  Email { get; set; }
        public string?  Password { get; set; }
        public string?  ConformPassword { get; set; }
    }
}
