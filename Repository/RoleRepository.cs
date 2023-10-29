using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class RoleRepository : IRole
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public Task<Role> GetRoleId(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Role> GetRoles()
        {
            return _context.Roles.OrderBy(r => r.Roleid).ToList();
        }
    }
}
