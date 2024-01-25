
using AppDomain.Dto;
using bzbackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<JIbadah> JIbadahs { get; set; }
        public DbSet<KepalaKeluarga> KepalaKeluargas { get; set; }
        public DbSet<LiturgiIbadah> LiturgiIbadahs { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    /*
        //    modelBuilder.Entity<Users>()
        //        .HasMany(b => b.Beritas)
        //        .WithOne(u => u.Users)
        //        .HasForeignKey(u => u.Usersid);

        //    modelBuilder.Entity<Sektor>()
        //        .HasMany(j => j.Jemaats)
        //        .WithOne(s => s.Sektor)
        //        .HasForeignKey(s => s.Sektorid);


        //    modelBuilder.Entity<Users>()
        //        .HasMany(r => r.Renungans)
        //        .WithOne(u => u.Users)
        //        .HasForeignKey(u => u.Usersid);

        //    modelBuilder.Entity<Users>()
        //        .HasMany(ji => ji.JIbadahs)
        //        .WithOne(u => u.Users)
        //        .HasForeignKey(u => u.Usersid);
        //    */

        //}
    }
}
