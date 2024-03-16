using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class KepalaKeluargaRepository : IKeluarga
    {
        private readonly DataContext _context;

        public KepalaKeluargaRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<KepalaKeluarga> GetKkels()
        {
            return _context.KepalaKeluargas.ToList();
        }

        public KepalaKeluarga GetKkel(int Kkelid)
        {
            return _context.KepalaKeluargas.Where(kk => kk.Kkelid == Kkelid).FirstOrDefault();
        }

        public Task<KepalaKeluarga> GetById(int Kkelid)
        {
            return Task.FromResult(_context.KepalaKeluargas.FirstOrDefault(kk => kk.Kkelid == Kkelid));
        }

        public async Task<KepalaKeluarga> Post(KepalaKeluarga kkel)
        {
            var tambah = await _context.KepalaKeluargas.AddAsync(kkel);
            await _context.SaveChangesAsync();
            return tambah.Entity;
        }

        public async Task<KepalaKeluarga> Update(KepalaKeluarga kkel)
        {
            var dataindb = _context.KepalaKeluargas.SingleOrDefault(x => x.Kkelid == kkel.Kkelid);
            dataindb.namalengkap = kkel.namalengkap;
            dataindb.nik = kkel.nik;
            dataindb.jeniskelamin = kkel.jeniskelamin;
            dataindb.tempatlahir = kkel.tempatlahir;
            dataindb.tangallahir = kkel.tangallahir;
            dataindb.alamat =kkel.alamat;
            dataindb.pendidikan = kkel.pendidikan;
            dataindb.jenispekerjaan = kkel.jenispekerjaan;
            dataindb.golongandarah = kkel.golongandarah;
            dataindb.statusperkawinan = kkel.statusperkawinan;
            dataindb.statusdalamkeluarga = kkel.statusdalamkeluarga;
            dataindb.baptis = kkel.baptis;
            dataindb.sidi = kkel.sidi;
            dataindb.nokontak = kkel.nokontak;
            dataindb.Sektorid = kkel.Sektorid;
            _context.SaveChangesAsync();
            return dataindb;

        }
        public Task<bool> Delete(int Kkelid)
        {
            var data = _context.KepalaKeluargas.Find(Kkelid);
            _context.KepalaKeluargas.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
