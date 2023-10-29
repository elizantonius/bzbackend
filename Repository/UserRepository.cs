using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class UserRepository : IUsers
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public Task<Users> GetById(int id)
        {
            return Task.FromResult(_context.Users.FirstOrDefault(u => u.Usersid == id));
        }

        public ICollection<Users> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Usersid).ToList();
        }

        public Users GetUsers(int id)
        {
            return _context.Users.Where(u => u.Usersid == id).FirstOrDefault();
        }

        public Users GetUsers(string username)
        {
            return _context.Users.Where(u => u.username == username).FirstOrDefault();
        }
    }
}
