using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IRenunganRepository
    {
        ICollection<Renungan> GetRenungans();
    }
}
