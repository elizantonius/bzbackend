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

        public ICollection<Users> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Usersid).ToList();
        }
    }
}
