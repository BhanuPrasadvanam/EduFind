using EduFind.Models;
using EduFindAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EduFind.Repository
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly EduFindContext _context;

        public InstitutionRepository(EduFindContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Institution>> GetAllAsync()
        {
            return await _context.Institutions.ToListAsync();
        }

        public async Task<Institution> GetByIdAsync(int id)
        {
            return await _context.Institutions.FindAsync(id);
        }

        public async Task AddAsync(Institution institution)
        {
            _context.Institutions.Add(institution);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Institution institution)
        {
            _context.Institutions.Update(institution);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Institutions.FindAsync(id);
            if (data != null)
            {
                _context.Institutions.Remove(data);
                await _context.SaveChangesAsync();
            }
        }
    }
}