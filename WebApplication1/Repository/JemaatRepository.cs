using AppDomain.Interfaces;
using AppDomain.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class JemaatRepository : IJemaatRepository
    {
        private readonly AplicationDbContext _context;

        public JemaatRepository(AplicationDbContext context)
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
            dataindb.namalengkap = jemaat.namalengkap;
            dataindb.nik = jemaat.nik;
            dataindb.jeniskelamin = jemaat.jeniskelamin;
            dataindb.tempatlahir = jemaat.tempatlahir;
            dataindb.tangallahir = jemaat.tangallahir;
            dataindb.alamat = jemaat.alamat;
            dataindb.pendidikan = jemaat.pendidikan;
            dataindb.jenispekerjaan = jemaat.jenispekerjaan;
            dataindb.golongandarah = jemaat.golongandarah;
            dataindb.statusperkawinan = jemaat.statusperkawinan;
            dataindb.statusdalamkeluarga = jemaat.statusdalamkeluarga;
            dataindb.baptis = jemaat.baptis;
            dataindb.sidi = jemaat.sidi;
            dataindb.nokontak = jemaat.nokontak;
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




