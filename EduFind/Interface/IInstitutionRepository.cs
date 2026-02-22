using EduFind.Models;

namespace EduFind.Repository
{
    public interface IInstitutionRepository
    {
        Task<IEnumerable<Institution>> GetAllAsync();
        Task<Institution> GetByIdAsync(int id);
        Task AddAsync(Institution institution);
        Task UpdateAsync(Institution institution);
        Task DeleteAsync(int id);
    }
}
