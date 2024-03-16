using bzbackend.Models;
using AppDomain.Models;

namespace bzbackend.Interfaces
{
    public interface IKeluarga
    {
        ICollection<Keluarga> GetKkels();
        Keluarga GetKkel(int Id);
        Task<Keluarga> GetById(int Id);
        Task<Keluarga> Post(Keluarga keluarga);
        Task<Keluarga> Update(Keluarga keluarga);
        Task<bool> Delete(int Id);
    }
}
