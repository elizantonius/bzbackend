using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;

namespace bzbackend.Repository
{
    public class RenunganRepository : IRenunganRepository
    {
        private readonly DataContext _context;

        public RenunganRepository(DataContext context)
        {
            _context = context;
        }

        public  ICollection<Renungan> GetRenungans()
        {
            return _context.Renungans.OrderBy(r => r.Renunganid).ToList();
        }
    }
    
}
