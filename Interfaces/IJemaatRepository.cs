using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IJemaatRepository
    {
        ICollection<Jemaat> GetJemaat();
        Task<Jemaat> GetById(int id);
        Task<Jemaat> Post(Jemaat value);
        Task<bool> Put(int id, Jemaat value);
        Task<bool> Delete(int id);
    }
}
