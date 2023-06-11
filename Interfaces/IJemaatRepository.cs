using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IJemaatRepository
    {
        ICollection<Jemaat> GetJemaats();
    }
}
