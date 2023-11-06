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
            return _context.Jemaats.OrderBy(j => j.Jemaatid).ToList();
        }


        public Task<Jemaat> GetById(int id)
        {
            return Task.FromResult(_context.Jemaats.FirstOrDefault(x => x.Jemaatid == id));
        }

        public async Task<Jemaat> Post(Jemaat value)
        {
            try
            {
                _context.Jemaats.Add(value);
                await _context.SaveChangesAsync();
                return value;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        public async Task<bool> Put(int id, Jemaat value)
        {
            try
            {
                var oldData = _context.Jemaats.FirstOrDefault(x => x.Jemaatid == id);
                ArgumentNullException.ThrowIfNull(oldData, "Tidak Ditemukan");
                _context.Entry(oldData).CurrentValues.SetValues(value);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var oldData = _context.Jemaats.FirstOrDefault(x => x.Jemaatid == id);
                ArgumentNullException.ThrowIfNull(oldData, "Tidak Ditemukan");
                _context.Jemaats.Remove(oldData);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }

        }

    }
}




