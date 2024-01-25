using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IBeritaRepository
    {
        ICollection<Berita> GetBeritas();
        Task<Berita> GetById(int id);
        Task<Berita> Post(Berita berita);
        Task<Berita> Put(Berita berita);
        Task<bool> Delete(int id);
    }
}
