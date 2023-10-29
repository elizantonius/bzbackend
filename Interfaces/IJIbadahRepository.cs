using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IJIbadahRepository
    {
        ICollection<JIbadah> GetJIbadahs();
        Task<JIbadah> GetById(int id);
    }
}
