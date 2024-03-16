using AppDomain.Models;
using bzbackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AplicationDbContext : IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> option) : base(option) { }

        public DbSet<Berita> Beritas { get; set; }
        public DbSet<Jemaat> Jemaats { get; set; }
        public DbSet<Renungan> Renungans { get; set; }
        public DbSet<Sektor> Sektors { get; set; }
        public DbSet<JIbadah> JIbadahs { get; set; }
        public DbSet<Keluarga> Keluargas { get; set; }
        public DbSet<WartaJemaat> WartaJemaats { get; set; }
    }
}