using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IRole
    {
        ICollection<Role> GetRoles();
    }
}
