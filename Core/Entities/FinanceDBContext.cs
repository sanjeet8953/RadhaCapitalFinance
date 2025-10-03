using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RadhaCapitalFinance.Core.Entities
{
    public class FinanceDBContext : DbContext
    {
        public FinanceDBContext(DbContextOptions options) : base(options)
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
        public DbSet<AdminModel> Admin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Existing DateTime UTC conversion
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

            // 👇 First Admin Seed
            //modelBuilder.Entity<AdminModel>().HasData(
            //    new AdminModel
            //    {
            //        Id = 1,
            //        AdminName = "SuperAdmin",
            //        Email = "admin@example.com",
            //        Password = "Admin@123", // production me hashing use karo
            //        Role = "Admin",
            //        UserId = "admin"
            //    }
            //);

            base.OnModelCreating(modelBuilder);
        }
    }
}
