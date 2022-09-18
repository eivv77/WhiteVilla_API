using System.Linq.Expressions;
using WhiteVilla_VillaAPI.Models;

namespace WhiteVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity); 
    }
}
