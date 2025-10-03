using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RadhaCapitalFinance.Core.Entities;

namespace RadhaCapitalFinance.Core.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllDataAsync();
        Task AddAsync(T model);
        Task<T?> GetByIdAsync(int id);
        Task UpdateAsync(T model);
        Task DeleteAsync(int id);
        
    }

}
