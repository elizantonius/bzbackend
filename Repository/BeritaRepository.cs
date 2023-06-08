using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class BeritaRepository : IBeritaRepository
    {
        private readonly DataContext _context;
        public BeritaRepository(DataContext context)
        {
            _context = context; 
                
        }

        public ICollection<Berita> GetBeritas()
        {
            return _context.Beritas.OrderBy(b => b.Beritaid).ToList();
        }
    }
}
