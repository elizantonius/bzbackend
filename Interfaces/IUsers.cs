using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IUsers
    {
        ICollection<Users> GetUsers();
        Users GetUsers(int id);
        Users GetUsers(string username);
        Task<Users> GetById(int id);
       
    }
}
