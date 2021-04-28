using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aytam.Data;
using Microsoft.EntityFrameworkCore;

namespace Aytam.Logic
{
    public class SponsorService
    {
        private ApplicationDbContext _db;

        public SponsorService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task<IEnumerable<Sponsor>> GetAllSponsors()
        {
            return await _db.Sponsors.ToListAsync();
        }
    }
}
