using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ApartmentRepo : RepositoryBase, IRepository<Apartment>
    {


        public ApartmentRepo(RepoContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Apartment>> GetAll()
        {
            return await _context.Apartments.ToListAsync();
        }

        public async Task<Apartment> GetById(int id)
        {
            return await _context.Apartments
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
