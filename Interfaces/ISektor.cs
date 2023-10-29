using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface ISektor
    {
        ICollection<Sektor> GetSektors();
        Sektor GetSektor(int id);
        Sektor GetSektor(string nama);
        Task<Sektor> GetById(int id);
    }
}
