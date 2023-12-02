﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bzbackend.Data;

#nullable disable

namespace bzbackend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231126115139_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("Usersid");

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

                    b.HasIndex("Usersid");

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

                    b.HasIndex("Sektorid")
                        .IsUnique();

                    b.ToTable("Jemaats");
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

                    b.HasIndex("Usersid");

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

                    b.HasIndex("Roleid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Berita", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.JIbadah", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Jemaat", b =>
                {
                    b.HasOne("bzbackend.Models.Sektor", "Sektor")
                        .WithOne("jemaat")
                        .HasForeignKey("bzbackend.Models.Jemaat", "Sektorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sektor");
                });

            modelBuilder.Entity("bzbackend.Models.Renungan", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Users", b =>
                {
                    b.HasOne("bzbackend.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("bzbackend.Models.Sektor", b =>
                {
                    b.Navigation("jemaat")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}