using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IJIbadahRepository
    {
        ICollection<JIbadah> GetJIbadahs();
    }
}
