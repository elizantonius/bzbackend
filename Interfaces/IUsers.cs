using bzbackend.Models;

namespace bzbackend.Interfaces
{
    public interface IUsers
    {
        ICollection<Users> GetUsers();
        Users GetUsers(int id);
        Users GetUsers(string username);
        Task<Users> GetById(int id);
        Task<Users> Post(Users users);
        Task<Users> Put(Users users);
        Task<bool> Delete(int id);
       
    }
}
