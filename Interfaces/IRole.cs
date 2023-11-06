using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IRole
    {
        ICollection<Role> GetRoles();
        Role GetRole(int Roleid);
        Role GetRole(string nama);

        Task <Role> GetById(int Roleid);
    }
}
