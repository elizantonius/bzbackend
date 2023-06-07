﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
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
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bzbackend.Models.Berita", b =>
                {
                    b.Property<int>("Beritaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Beritaid"));

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("gambar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("judul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime2");

                    b.HasKey("Beritaid");

                    b.HasIndex("Usersid");

                    b.ToTable("Beritas");
                });

            modelBuilder.Entity("bzbackend.Models.JIbadah", b =>
                {
                    b.Property<int>("JIbadahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JIbadahId"));

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("liturgos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("namakel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pelayan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime2");

                    b.HasKey("JIbadahId");

                    b.HasIndex("Usersid");

                    b.ToTable("JIbadahs");
                });

            modelBuilder.Entity("bzbackend.Models.Jemaat", b =>
                {
                    b.Property<int>("Jemaatid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Jemaatid"));

                    b.Property<int>("Sektorid")
                        .HasColumnType("int");

                    b.Property<string>("alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("golongandarah")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nokontak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pekerjaan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("tglkelahiran")
                        .HasColumnType("datetime2");

                    b.HasKey("Jemaatid");

                    b.HasIndex("Sektorid");

                    b.ToTable("Jemaats");
                });

            modelBuilder.Entity("bzbackend.Models.Renungan", b =>
                {
                    b.Property<int>("Renunganid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Renunganid"));

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.Property<string>("doa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isirenungan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("judulrenungan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pembacaan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Renunganid");

                    b.HasIndex("Usersid");

                    b.ToTable("Renungans");
                });

            modelBuilder.Entity("bzbackend.Models.Role", b =>
                {
                    b.Property<int>("Roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Roleid"));

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Roleid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("bzbackend.Models.Sektor", b =>
                {
                    b.Property<int>("Sektorid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sektorid"));

                    b.Property<int>("nama")
                        .HasColumnType("int");

                    b.HasKey("Sektorid");

                    b.ToTable("Sektors");
                });

            modelBuilder.Entity("bzbackend.Models.Users", b =>
                {
                    b.Property<int>("Usersid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usersid"));

                    b.Property<int>("Roleid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usersid");

                    b.HasIndex("Roleid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Berita", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany("Beritas")
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.JIbadah", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany("JIbadahs")
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Jemaat", b =>
                {
                    b.HasOne("bzbackend.Models.Sektor", "Sektor")
                        .WithMany("Jemaats")
                        .HasForeignKey("Sektorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sektor");
                });

            modelBuilder.Entity("bzbackend.Models.Renungan", b =>
                {
                    b.HasOne("bzbackend.Models.Users", "Users")
                        .WithMany("Renungans")
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Users", b =>
                {
                    b.HasOne("bzbackend.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("bzbackend.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("bzbackend.Models.Sektor", b =>
                {
                    b.Navigation("Jemaats");
                });

            modelBuilder.Entity("bzbackend.Models.Users", b =>
                {
                    b.Navigation("Beritas");

                    b.Navigation("JIbadahs");

                    b.Navigation("Renungans");
                });
#pragma warning restore 612, 618
        }
    }
}
