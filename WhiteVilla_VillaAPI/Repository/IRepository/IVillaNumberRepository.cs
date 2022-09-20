using System.Linq.Expressions;
using WhiteVilla_VillaAPI.Models;

namespace WhiteVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity); 
    }
}
