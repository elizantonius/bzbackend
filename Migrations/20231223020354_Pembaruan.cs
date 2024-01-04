using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bzbackend.Migrations
{
    /// <inheritdoc />
    public partial class Pembaruan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KepalaKeluargas",
                table: "KepalaKeluargas");

            migrationBuilder.DropColumn(
                name: "alamat",
                table: "Jemaats");

            migrationBuilder.DropColumn(
                name: "golongandarah",
                table: "Jemaats");

            migrationBuilder.DropColumn(
                name: "nama",
                table: "Jemaats");

            migrationBuilder.DropColumn(
                name: "nokontak",
                table: "Jemaats");

            migrationBuilder.DropColumn(
                name: "pekerjaan",
                table: "Jemaats");

            migrationBuilder.DropColumn(
                name: "tglkelahiran",
                table: "Jemaats");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LiturgiIbadahs",
                newName: "Libid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KepalaKeluargas",
                newName: "Sektorid");

            migrationBuilder.RenameColumn(
                name: "Sektorid",
                table: "Jemaats",
                newName: "Kkelid");

            migrationBuilder.AlterColumn<int>(
                name: "Sektorid",
                table: "KepalaKeluargas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Kkelid",
                table: "KepalaKeluargas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "alamat",
                table: "KepalaKeluargas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nokontak",
                table: "KepalaKeluargas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepalaKeluargas",
                table: "KepalaKeluargas",
                column: "Kkelid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KepalaKeluargas",
                table: "KepalaKeluargas");

            migrationBuilder.DropColumn(
                name: "Kkelid",
                table: "KepalaKeluargas");

            migrationBuilder.DropColumn(
                name: "alamat",
                table: "KepalaKeluargas");

            migrationBuilder.DropColumn(
                name: "nokontak",
                table: "KepalaKeluargas");

            migrationBuilder.RenameColumn(
                name: "Libid",
                table: "LiturgiIbadahs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Sektorid",
                table: "KepalaKeluargas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Kkelid",
                table: "Jemaats",
                newName: "Sektorid");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "KepalaKeluargas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "alamat",
                table: "Jemaats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "golongandarah",
                table: "Jemaats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nama",
                table: "Jemaats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nokontak",
                table: "Jemaats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "pekerjaan",
                table: "Jemaats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "tglkelahiran",
                table: "Jemaats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_KepalaKeluargas",
                table: "KepalaKeluargas",
                column: "Id");
        }
    }
}
