using EduFind.Models;
using Microsoft.EntityFrameworkCore;

namespace EduFindAPI.Data
{
    public class EduFindContext : DbContext
    {
        public EduFindContext(DbContextOptions<EduFindContext> options)
            : base(options) { }

        public DbSet<Institution> Institutions { get; set; }
    }
}