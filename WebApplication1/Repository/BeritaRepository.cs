﻿using AppDomain.Interfaces;
using AppDomain.Models;
using WebApplication1.Data;

namespace bzbackend.Repository
{
    public class BeritaRepository : IBeritaRepository
    {
        private readonly AplicationDbContext _context;
        public BeritaRepository(AplicationDbContext context)
        {
            _context = context;

        }

        public ICollection<Berita> GetBeritas()
        {
            return _context.Beritas.ToList();
        }

        public Task<Berita> GetById(int id)
        {
            return Task.FromResult(_context.Beritas.FirstOrDefault(b => b.Beritaid == id));
        }

        /*public Task<Berita> GetById(int id)
        {
            throw new NotImplementedException();
        }
        */
        public async Task<Berita> Post(Berita berita)
        {
            var filename = Path.GetRandomFileName();
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "BeritaImg");
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            var completepath = Path.Combine(filepath, filename);
            File.WriteAllBytes(completepath, berita.FileData);
            berita.gambar = filename;
            var hasil = await _context.Beritas.AddAsync(berita);
            await _context.SaveChangesAsync();
            return hasil.Entity;
        }

        public async Task<Berita> Put(Berita berita)
        {
            var dataindb = _context.Beritas.SingleOrDefault(x => x.Beritaid == berita.Beritaid);
            dataindb.judul = berita.judul;
            dataindb.gambar = berita.gambar;
            dataindb.isi = berita.isi;
            dataindb.tanggal = berita.tanggal;
            _context.SaveChangesAsync();
            return dataindb;
        }

        public Task<bool> Delete(int id)
        {
            var data = _context.Beritas.Find(id);
            _context.Beritas.Remove(data);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
