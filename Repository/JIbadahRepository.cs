using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class JIbadahRepository : IJIbadahRepository
    {
        private readonly DataContext _context;
        public JIbadahRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<JIbadah> GetJIbadahs()
        {
            return _context.JIbadahs.OrderBy(ji => ji.JIbadahId).ToList();
        }
    }
}
