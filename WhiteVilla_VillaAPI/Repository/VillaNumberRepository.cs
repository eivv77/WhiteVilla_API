using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WhiteVilla_VillaAPI.Data;
using WhiteVilla_VillaAPI.Models;
using WhiteVilla_VillaAPI.Repository.IRepository;

namespace WhiteVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedTime = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
