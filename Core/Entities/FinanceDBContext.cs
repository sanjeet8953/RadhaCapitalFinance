using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RadhaCapitalFinance.Core.Entities
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
                    {
                        property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                            v => v.Kind == DateTimeKind.Utc ? v : v.ToUniversalTime(),
                            v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
                        ));
                    }
                }
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
