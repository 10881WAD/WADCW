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

        public async Task Create(Apartment entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Apartment entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var apartment = await _context.Apartments.FindAsync(id);
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Apartment>> GetAll()
        {

            return await _context.Apartments
               .Include(a => a.Region)
               .ToListAsync();
        }

        public async Task<Apartment> GetById(int id)
        {
            return await _context.Apartments
                .FirstOrDefaultAsync(m => m.Id == id);
        }

       
    }
}
