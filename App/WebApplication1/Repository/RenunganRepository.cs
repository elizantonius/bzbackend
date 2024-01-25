using bzbackend.Interfaces;
using bzbackend.Models;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class RenunganRepository : IRenunganRepository
    {
        private readonly AplicationDbContext _context;

        public RenunganRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public  ICollection<Renungan> GetRenungans()
        {
            return _context.Renungans.ToList();
        }

        public Task<Renungan> GetById(int id)
        {
            return Task.FromResult(_context.Renungans.FirstOrDefault(r => r.Renunganid == id));
        }

        public async Task<Renungan> Post(Renungan renungan)
        {
            var hasil = await _context.Renungans.AddAsync(renungan);
            await _context.SaveChangesAsync();
            return hasil.Entity;
        }

        public async Task<Renungan> Put(Renungan renungan)
        {
            var dataindb = _context.Renungans.SingleOrDefault(x => x.Renunganid == renungan.Renunganid);
            dataindb.judulrenungan = renungan.judulrenungan;
            dataindb.nats = renungan.nats;
            dataindb.pembacaan = renungan.pembacaan;
            dataindb.isirenungan = renungan.isirenungan;
            dataindb.doa = renungan.doa;
            dataindb.Usersid = renungan.Usersid;
            _context.SaveChangesAsync();
            return dataindb;
        }

        public Task<bool> Delete(int Renunganid)
        {
            var data = _context.Renungans.Find(Renunganid);
            _context.Renungans.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
    
}
