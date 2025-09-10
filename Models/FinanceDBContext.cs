using Microsoft.EntityFrameworkCore;

namespace RadhaCapitalFinance.Models
{
    public class FinanceDBContext:DbContext
    {
        public FinanceDBContext(DbContextOptions options) : base(options) //constructer parameter DbContextOption pridefine class
        {
               
        }
        public DbSet<FinanceModel> Insurance { get; set; }
        public DbSet<CarModel> Car { get; set; }
        public DbSet<CommercialModel> Commercial { get; set; }
        public DbSet<FireModel> Fire { get; set; }
        public DbSet<HealthModel> Helth { get; set; }
        public DbSet<LifeInsurenceModel> Life { get; set; }
        public DbSet<MarineInsuranceModel> Marine { get; set; }
        public DbSet<PropertyModel> Property { get; set; }
        public DbSet<RetirementModel> Retirement { get; set; }
        public DbSet<SIPModel> SIP { get; set; }
        public DbSet<TravelModel> Travel { get; set; }

    }
}
