using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IBeritaRepository
    {
        ICollection<Berita> GetBeritas();
    }
}
