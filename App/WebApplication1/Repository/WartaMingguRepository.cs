using bzbackend.Interfaces;
using bzbackend.Models;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class WartaMingguRepository : IWartaMinggu
    {
        private readonly AplicationDbContext _context;
        public WartaMingguRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<WartaJemaat> GetWartas()
        {
            return _context.WartaJemaats.ToList();
        }

        public Task<WartaJemaat> GetById(int Libid)
        {
            return Task.FromResult(_context.WartaJemaats.FirstOrDefault(l => l.Libid == Libid));
        }

        public async Task<WartaJemaat> Post(WartaJemaat liturgiIbadah)
        {
            var simpan = await _context.WartaJemaats.AddAsync(liturgiIbadah);
            await _context.SaveChangesAsync();
            return simpan.Entity;
        }

        public async Task<WartaJemaat> Put(WartaJemaat liturgiIbadah)
        {
            var dataindb = _context.WartaJemaats.SingleOrDefault(l=>l.Libid==liturgiIbadah.Libid);
            dataindb.liturgi = liturgiIbadah.liturgi;
            dataindb.Bacaan = liturgiIbadah.Bacaan;
            dataindb.PemimpinIbadah = liturgiIbadah.PemimpinIbadah;
            dataindb.Pendamping = liturgiIbadah.Pendamping;
            dataindb.PengakuanDosa = liturgiIbadah.PengakuanDosa;
            dataindb.Pembacaan = liturgiIbadah.Pembacaan;
            dataindb.PembacaWJ = liturgiIbadah.PembacaWJ;
            dataindb.PelayanaanOS = liturgiIbadah.PelayanaanOS;
            dataindb.Kolektaan = liturgiIbadah.Kolektaan;
            dataindb.PemainKeyboard = liturgiIbadah.PemainKeyboard;
            dataindb.Nyanyian = liturgiIbadah.Nyanyian;
            dataindb.MajelisPiket = liturgiIbadah.MajelisPiket;
            _context.SaveChangesAsync();
            return dataindb;
        }
        public Task<bool> Delete(int Libid)
        {
            var data = _context.WartaJemaats.Find(Libid);
            _context.WartaJemaats.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
