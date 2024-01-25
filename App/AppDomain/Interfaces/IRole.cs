using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IRole
    {
        ICollection<Role> GetRoles();
        Role GetRole(int Roleid);
        Role GetRole(string nama);
        Task <Role> GetById(int Roleid);
        Task <Role> AddRole(Role role);
        Task<Role> Update(Role role);
        Task <bool> DeleteRole(int Roleid);
        
    }
}
