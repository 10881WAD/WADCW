using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RegionRepo : RepositoryBase, IRepository<Region>
    {
        public RegionRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Region>> GetAll()
        {
            return await _context.Regions.ToListAsync();
        }

        public async Task<Region> GetById(int id)
        {
            return await _context.Regions
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
