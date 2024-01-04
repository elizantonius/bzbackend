using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IKepalaKeluarga
    {
        ICollection<KepalaKeluarga> GetKkels();
        KepalaKeluarga GetKkel(int Kkelid);
        Task<KepalaKeluarga> GetById(int Kkelid);
        Task<KepalaKeluarga> Post(KepalaKeluarga kkel);
        Task<KepalaKeluarga> Update(KepalaKeluarga kkel);
        Task<bool> Delete(int Kkelid);
    }
}
