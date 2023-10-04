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

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Berita> GetBeritas()
        {
            return _context.Beritas.OrderBy(b => b.Beritaid).ToList();
        }

        public Task<Berita> GetById(int  id)
        {
            return Task.FromResult(_context.Beritas.FirstOrDefault(b => b.Beritaid == id));
        }

        /*public Task<Berita> GetById(int id)
        {
            throw new NotImplementedException();
        }
        */
        public Task<Berita> Post(Berita value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Put(int id, Berita value)
        {
            throw new NotImplementedException();
        }
    }
}
