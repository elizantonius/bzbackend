using bzbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace bzbackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Berita> Beritas { get; set; }
        public DbSet<Jemaat> Jemaats { get; set; }
        public DbSet<Renungan> Renungans { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sektor> Sektors { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasMany(b => b.Beritas)
                .WithOne(u => u.Users)
                .HasForeignKey(u => u.Usersid);

            modelBuilder.Entity<Sektor>()
                .HasMany(j => j.Jemaats)
                .WithOne(s => s.Sektor)
                .HasForeignKey(s => s.Sektorid);

            modelBuilder.Entity<Role>()
                .HasMany(u => u.Users)
                .WithOne(r => r.Role)
                .HasForeignKey(r => r.Roleid);

            modelBuilder.Entity<Users>()
                .HasMany(r => r.Renungans)
                .WithOne(u => u.Users)
                .HasForeignKey(u => u.Usersid);

        }
    }
}
