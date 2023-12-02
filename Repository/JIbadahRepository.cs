using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;

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
            return _context.JIbadahs.ToList();
        }

        public Task<JIbadah> GetById(int id)
        {
            return Task.FromResult(_context.JIbadahs.FirstOrDefault(ji => ji.JIbadahId == id));
        }

        public async Task<JIbadah> Post(JIbadah jibadah)
        {
            var tambah = await _context.JIbadahs.AddAsync(jibadah);
            await _context.SaveChangesAsync();
            return tambah.Entity;
        }

        public async Task<JIbadah> Put(JIbadah jibadah)
        {
            var dataindb = _context.JIbadahs.SingleOrDefault(x => x.JIbadahId == jibadah.JIbadahId);
            dataindb.tanggal = jibadah.tanggal;
            dataindb.namakel = jibadah.namakel;
            dataindb.pelayan = jibadah.liturgos;
            dataindb.Usersid = jibadah.Usersid;
            _context.SaveChangesAsync();
            return dataindb;
        }

        public Task<bool> Delete(int JIbadahId)
        {
            var data = _context.JIbadahs.Find(JIbadahId);
            _context.JIbadahs.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
