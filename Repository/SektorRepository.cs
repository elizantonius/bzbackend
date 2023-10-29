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

        public Task<Sektor> GetById(int id)
        {
            return Task.FromResult(_context.Sektors.FirstOrDefault(s => s.Sektorid == id));
        }

        public Sektor GetSektor(int id)
        {
            return _context.Sektors.Where(s => s.Sektorid == id).FirstOrDefault();
        }

        public Sektor GetSektor(string nama)
        {
            return _context.Sektors.Where(s => s.nama == nama).FirstOrDefault();
        }

        public ICollection<Sektor> GetSektors() 
        { 
            return _context.Sektors.OrderBy(s => s.Sektorid).ToList();
        }
    }
}
