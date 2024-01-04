using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class KepalaKeluargaRepository : IKepalaKeluarga
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

        public Task<KepalaKeluarga> Post(KepalaKeluarga kkel)
        {
            throw new NotImplementedException();
        }

        public Task<KepalaKeluarga> Update(KepalaKeluarga kkel)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(int Kkelid)
        {
            throw new NotImplementedException();
        }

        public Task<KepalaKeluarga> GetById(int Kkelid)
        {
            return Task.FromResult(_context.KepalaKeluargas.FirstOrDefault(kk => kk.Kkelid == Kkelid));
        }
    }
}
