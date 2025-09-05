using Microsoft.EntityFrameworkCore;

namespace RadhaCapitalFinance.Models
{
    public class FinanceDBContext:DbContext
    {
        public FinanceDBContext(DbContextOptions options) : base(options) //constructer parameter DbContextOption pridefine class
        {
               
        }
        public DbSet<FinanceModel> Insurance { get; set; }

    }
}
