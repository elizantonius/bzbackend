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
            return _context.Roles.ToList();
        }

        public Role GetRole(int Roleid)
        {
            return _context.Roles.Where(r => r.Roleid == Roleid).FirstOrDefault();
        }

        public Role GetRole(string nama)
        {
            return _context.Roles.Where(r => r.nama.Contains(nama)).FirstOrDefault();
        }

        public Task<Role> GetById(int Roleid)
        {
            return Task.FromResult(_context.Roles.FirstOrDefault(r=> r.Roleid==Roleid));
        }

        public async Task<Role> AddRole(Role role)
        {
            var hasil = await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
            return hasil.Entity;
        }

        public async Task<Role> Update(Role role)
        {

            var dataindatabase = _context.Roles.SingleOrDefault(x=>x.Roleid==role.Roleid);
            dataindatabase.nama = role.nama;
            _context.SaveChangesAsync();
            return dataindatabase;
            
        }

        public Task<bool> DeleteRole(int Roleid)
        {
            var data = _context.Roles.Find(Roleid);
            _context.Roles.Remove(data);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
