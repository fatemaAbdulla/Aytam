using Aytam.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Aytam.Logic
{
    public class OrphanService
    {
        private readonly ApplicationDbContext _db;
        public OrphanService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task<IEnumerable<Orphan>> GetAllOrphans()
        {
            return await _db.Orphans.ToListAsync();

        }
    }

}