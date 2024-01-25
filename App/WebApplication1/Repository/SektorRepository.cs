using bzbackend.Interfaces;
using bzbackend.Models;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class SektorRepository : ISektor
    {
        private readonly AplicationDbContext _context;
        public SektorRepository(AplicationDbContext context)
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
            return _context.Sektors.ToList();
        }

        public async Task<Sektor> Post(Sektor sektor)
        {
            var tambah = await _context.Sektors.AddAsync(sektor);
            await _context.SaveChangesAsync();
            return tambah.Entity;
        }

        public async Task<Sektor> Put(Sektor sektor)
        {
            var dataindb = _context.Sektors.SingleOrDefault(x => x.Sektorid == sektor.Sektorid);
            dataindb.nama = sektor.nama;
            _context.SaveChangesAsync();
            return dataindb;
        }

        public Task<bool> Delete(int id)
        {
            var data = _context.Sektors.Find(id);
            _context.Sektors.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
