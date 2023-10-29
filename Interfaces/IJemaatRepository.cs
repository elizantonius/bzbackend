using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IJemaatRepository
    {
        ICollection<Jemaat> GetJemaat(int jemaatId);
        Task<Jemaat> GetById(int id);
        Task<Jemaat> Post(Jemaat value);
        Task<bool> Put(int id, Jemaat value);
        Task<bool> Delete(int id);
        bool JemaatExists(int jemaatId);
        bool CreateJemaat(Jemaat jemaat);
        bool Save();
        object GetJemaat();
    }
}
