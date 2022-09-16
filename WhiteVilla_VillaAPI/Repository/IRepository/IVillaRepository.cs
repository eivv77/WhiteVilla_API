using System.Linq.Expressions;
using WhiteVilla_VillaAPI.Models;

namespace WhiteVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null);
        Task<Villa> GetByIdAsync(Expression<Func<Villa, bool>> filter = null, bool tracked = true);
        Task CreateAsync(Villa entity); 
        Task UpdateAsync(Villa entity); 
        Task RemoveAsync(Villa entity);
        Task SaveAsync();
    }
}
