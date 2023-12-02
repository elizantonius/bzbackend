using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace bzbackend.Repository
{
    public class JemaatRepository : IJemaatRepository
    {
        private readonly DataContext _context;

        public JemaatRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Jemaat> GetJemaat()
        {
            return _context.Jemaats.ToList();
        }


        public Task<Jemaat> GetById(int id)
        {
            return Task.FromResult(_context.Jemaats.FirstOrDefault(x => x.Jemaatid == id));
        }

        public async Task<Jemaat> Post(Jemaat jemaat)
        {
            var tambah = await _context.Jemaats.AddAsync(jemaat);
            await _context.SaveChangesAsync();
            return tambah.Entity;

        }

        public async Task<Jemaat> Put(Jemaat jemaat)
        {
            var dataindb = _context.Jemaats.SingleOrDefault(x => x.Jemaatid == jemaat.Jemaatid);
            dataindb.nama = jemaat.nama;
            dataindb.alamat = jemaat.alamat;
            dataindb.pekerjaan = jemaat.pekerjaan;
            dataindb.tglkelahiran = jemaat.tglkelahiran;
            dataindb.golongandarah = jemaat.golongandarah;
            dataindb.nokontak = jemaat.nokontak;
            dataindb.Sektorid = jemaat.Sektorid;
            _context.SaveChangesAsync();
            return dataindb;
            
        }

        public  Task<bool> Delete(int id)
        {
            var data = _context.Jemaats.Find(id);
            _context.Jemaats.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);

        }
    }
}




