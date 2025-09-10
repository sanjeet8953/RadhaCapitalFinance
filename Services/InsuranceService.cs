using Microsoft.EntityFrameworkCore;
using RadhaCapitalFinance.Core.Entities;
using RadhaCapitalFinance.Core.Interfaces;

namespace RadhaCapitalFinance.Services
{
    public class InsuranceService : IInsuranceService
    {
        private readonly FinanceDBContext _context;
        public InsuranceService(FinanceDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FinanceModel>> GetAllDataAsync()
        {
            return await _context.Insurance.ToListAsync();
        }

        public async Task AddAsync(FinanceModel model)
        {
            await _context.Insurance.AddAsync(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Insurance.FindAsync(id);
            if (entity != null)
            {
                _context.Insurance.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
