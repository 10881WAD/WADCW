using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class HouseRepo : RepositoryBase, IRepository<House>
    {

        public HouseRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<House>> GetAll()
        {
            return await _context.Houses.ToListAsync();
        }

        public async Task<House> GetById(int id)
        {
            return await _context.Houses
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
