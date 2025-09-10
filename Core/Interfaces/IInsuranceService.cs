using RadhaCapitalFinance.Core.Entities;

namespace RadhaCapitalFinance.Core.Interfaces
{
    public interface IInsuranceService
    {
        Task<IEnumerable<FinanceModel>> GetAllDataAsync();
        Task AddAsync(FinanceModel model);
        Task DeleteAsync(int id);

    }
}
