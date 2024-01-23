using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bzbackend.Migrations
{
    /// <inheritdoc />
    public partial class gantijadwal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pelayan",
                table: "JIbadahs",
                newName: "tempat");

            migrationBuilder.RenameColumn(
                name: "namakel",
                table: "JIbadahs",
                newName: "pelayanan");

            migrationBuilder.AddColumn<string>(
                name: "alamat",
                table: "JIbadahs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "mc",
                table: "JIbadahs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alamat",
                table: "JIbadahs");

            migrationBuilder.DropColumn(
                name: "mc",
                table: "JIbadahs");

            migrationBuilder.RenameColumn(
                name: "tempat",
                table: "JIbadahs",
                newName: "pelayan");

            migrationBuilder.RenameColumn(
                name: "pelayanan",
                table: "JIbadahs",
                newName: "namakel");
        }
    }
}
