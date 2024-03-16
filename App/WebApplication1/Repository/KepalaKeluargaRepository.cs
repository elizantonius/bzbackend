using AppDomain.Models;
using bzbackend.Interfaces;
using bzbackend.Models;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class KepalaKeluargaRepository : IKeluarga
    {
        private readonly AplicationDbContext _context;

        public KepalaKeluargaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Keluarga> GetKkels()
        {
            return _context.Keluargas.ToList();
        }

        public Keluarga GetKkel(int Kkelid)
        {
            return _context.Keluargas.Where(kk => kk.Id == Kkelid).FirstOrDefault();
        }

        public Task<Keluarga> GetById(int Kkelid)
        {
            return Task.FromResult(_context.Keluargas.FirstOrDefault(kk => kk.Id == Kkelid));
        }

        public async Task<Keluarga> Post(Keluarga kkel)
        {
            var tambah = await _context.Keluargas.AddAsync(kkel);
            await _context.SaveChangesAsync();
            return tambah.Entity;
        }

        public async Task<Keluarga> Update(Keluarga kkel)
        {
            var dataindb = _context.Keluargas.SingleOrDefault(x => x.Id == kkel.Id);
            
            _context.SaveChangesAsync();
            return dataindb;

        }
        public Task<bool> Delete(int Kkelid)
        {
            var data = _context.Keluargas.Find(Kkelid);
            _context.Keluargas.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
