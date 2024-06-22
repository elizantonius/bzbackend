
using AppDomain.Models;

namespace AppDomain.Interfaces
{
    public interface IJIbadahRepository
    {
        ICollection<JIbadah> GetJIbadahs();
        Task<JIbadah> GetById(int id);
        Task<JIbadah> Post(JIbadah jibadah);
        Task<JIbadah> Put(JIbadah jibadah);
        Task<bool> Delete(int JIbadahId);
    }
}
