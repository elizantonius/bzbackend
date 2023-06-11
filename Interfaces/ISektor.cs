using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface ISektor
    {
        ICollection<Sektor> GetSektors();
    }
}
