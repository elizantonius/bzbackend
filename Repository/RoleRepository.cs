using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace bzbackend.Repository
{
    public class RoleRepository : IRole
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Role> GetRoles()
        {
            return _context.Roles.OrderBy(r => r.Roleid).ToList();
        }

        public Role GetRole(int Roleid)
        {
            return _context.Roles.Where(r => r.Roleid == Roleid).FirstOrDefault();
        }

        public Role GetRole(string nama)
        {
            return _context.Roles.Where(r => r.nama == nama).FirstOrDefault();
        }

       
    }
}
