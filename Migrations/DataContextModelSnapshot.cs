﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bzbackend.Data;

#nullable disable

namespace bzbackend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("bzbackend.Models.Berita", b =>
                {
                    b.Property<int>("Beritaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("gambar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("isi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("judul")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Beritaid");

                    b.ToTable("Beritas");
                });

            modelBuilder.Entity("bzbackend.Models.JIbadah", b =>
                {
                    b.Property<int>("JIbadahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("liturgos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("namakel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pelayan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime(6)");

                    b.HasKey("JIbadahId");

                    b.ToTable("JIbadahs");
                });

            modelBuilder.Entity("bzbackend.Models.Jemaat", b =>
                {
                    b.Property<int>("Jemaatid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Sektorid")
                        .HasColumnType("int");

                    b.Property<string>("alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golongandarah")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nokontak")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pekerjaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("tglkelahiran")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Jemaatid");

                    b.ToTable("Jemaats");
                });

            modelBuilder.Entity("bzbackend.Models.KepalaKeluarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("baptis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golongandarah")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("jeniskelamin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("jenispekerjaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("namalengkap")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("nik")
                        .HasColumnType("int");

                    b.Property<string>("pendidikan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("sidi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("statusdalamkeluarga")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("statusperkawinan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("tangallahir")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("tempatlahir")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("KepalaKeluargas");
                });

            modelBuilder.Entity("bzbackend.Models.LiturgiIbadah", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bacaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Kolektaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MajelisPiket")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nyanyian")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PelayanaanOS")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PemainKeyboard")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PembacaWJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pembacaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PemimpinIbadah")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pendamping")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PengakuanDosa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("liturgi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("LiturgiIbadahs");
                });

            modelBuilder.Entity("bzbackend.Models.Renungan", b =>
                {
                    b.Property<int>("Renunganid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("doa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("isirenungan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("judulrenungan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nats")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pembacaan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Renunganid");

                    b.ToTable("Renungans");
                });

            modelBuilder.Entity("bzbackend.Models.Role", b =>
                {
                    b.Property<int>("Roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Roleid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("bzbackend.Models.Sektor", b =>
                {
                    b.Property<int>("Sektorid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Sektorid");

                    b.ToTable("Sektors");
                });

            modelBuilder.Entity("bzbackend.Models.Users", b =>
                {
                    b.Property<int>("Usersid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Roleid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("passwd")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Usersid");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
