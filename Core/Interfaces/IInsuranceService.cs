using RadhaCapitalFinance.Core.Entities;

namespace RadhaCapitalFinance.Core.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllDataAsync();
        Task AddAsync(T model);
        Task DeleteAsync(int id);
    }

}
