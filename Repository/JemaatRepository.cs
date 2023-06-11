using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class JemaatRepository : IJemaatRepository
    {
        private readonly DataContext _context;

        public JemaatRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Jemaat> GetJemaats()
        {
            return _context.Jemaats.OrderBy(j => j.Jemaatid).ToList();
        }
    }
}
