using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class SektorRepository : ISektor
    {
        private readonly DataContext _context;
        public SektorRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Sektor> GetSektors() 
        { 
            return _context.Sektors.OrderBy(s => s.Sektorid).ToList();
        }
    }
}
