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
            return _context.Users.ToList();
        }

        public Users GetUsers(int id)
        {
            return _context.Users.Where(u => u.Usersid == id).FirstOrDefault();
        }

        public Users GetUsers(string username)
        {
            return _context.Users.Where(u => u.username == username).FirstOrDefault();
        }

        public async Task<Users> Post(Users users)
        {
            var tambah = await _context.Users.AddAsync(users);
            await _context.SaveChangesAsync();
            return tambah.Entity;

        }

        public async Task<Users> Put(Users users)
        {
            var dataindb = _context.Users.SingleOrDefault(x => x.Usersid == users.Usersid);
            dataindb.nama = users.nama;
            dataindb.email = users.email;
            dataindb.username = users.username;
            dataindb.passwd = users.passwd;
            dataindb.Roleid = users.Roleid;
            _context.SaveChangesAsync();
            return dataindb;
        }
        public Task<bool> Delete(int id)
        {
            var data = _context.Users.Find(id);
            _context.Users.Remove(data);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
