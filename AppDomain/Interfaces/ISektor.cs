using AppDomain.Models;

namespace AppDomain.Interfaces
{
    public interface ISektor
    {
        ICollection<Sektor> GetSektors();
        Sektor GetSektor(int id);
        Sektor GetSektor(string nama);
        Task<Sektor> GetById(int id);
        Task<Sektor> Post(Sektor sektor);
        Task<Sektor> Put(Sektor sektor);
        Task<bool> Delete(int id);
    }
}
