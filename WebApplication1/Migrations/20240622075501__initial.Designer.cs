﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20240622075501__initial")]
    partial class _initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppDomain.Models.Berita", b =>
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

            modelBuilder.Entity("AppDomain.Models.JIbadah", b =>
                {
                    b.Property<int>("JIbadahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("liturgos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("mc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("pelayanan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("tempat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JIbadahId");

                    b.ToTable("JIbadahs");
                });

            modelBuilder.Entity("AppDomain.Models.Jemaat", b =>
                {
                    b.Property<int>("Jemaatid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("KeluargaId")
                        .HasColumnType("int");

                    b.Property<string>("alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.Property<string>("nokontak")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.HasKey("Jemaatid");

                    b.HasIndex("KeluargaId");

                    b.ToTable("Jemaats");
                });

            modelBuilder.Entity("AppDomain.Models.Keluarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KepalaKeluaragJemaatid")
                        .HasColumnType("int");

                    b.Property<string>("NomorKK")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sektorid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KepalaKeluaragJemaatid");

                    b.HasIndex("Sektorid");

                    b.ToTable("Keluargas");
                });

            modelBuilder.Entity("AppDomain.Models.Renungan", b =>
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

            modelBuilder.Entity("AppDomain.Models.Sektor", b =>
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

            modelBuilder.Entity("AppDomain.Models.WartaJemaat", b =>
                {
                    b.Property<int>("Libid")
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

                    b.Property<DateTime?>("Tanggal")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("liturgi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Libid");

                    b.ToTable("WartaJemaats");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AppDomain.Models.Jemaat", b =>
                {
                    b.HasOne("AppDomain.Models.Keluarga", null)
                        .WithMany("AnggotaKeluarga")
                        .HasForeignKey("KeluargaId");
                });

            modelBuilder.Entity("AppDomain.Models.Keluarga", b =>
                {
                    b.HasOne("AppDomain.Models.Jemaat", "KepalaKeluarag")
                        .WithMany()
                        .HasForeignKey("KepalaKeluaragJemaatid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDomain.Models.Sektor", "Sektor")
                        .WithMany()
                        .HasForeignKey("Sektorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KepalaKeluarag");

                    b.Navigation("Sektor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppDomain.Models.Keluarga", b =>
                {
                    b.Navigation("AnggotaKeluarga");
                });
#pragma warning restore 612, 618
        }
    }
}
