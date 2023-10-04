using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IBeritaRepository
    {
        ICollection<Berita> GetBeritas();
        Task<Berita> GetById(int id);
        Task<Berita> Post(Berita value);
        Task<bool> Put(int id , Berita value);
        Task<bool> Delete(int id);
    }
}
