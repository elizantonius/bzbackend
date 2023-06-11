using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IUsers
    {
        ICollection<Users> GetUsers();
    }
}
