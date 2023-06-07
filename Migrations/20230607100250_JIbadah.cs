using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bzbackend.Migrations
{
    /// <inheritdoc />
    public partial class JIbadah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JIbadahs",
                columns: table => new
                {
                    JIbadahId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tanggal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    namakel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pelayan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liturgos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JIbadahs", x => x.JIbadahId);
                    table.ForeignKey(
                        name: "FK_JIbadahs_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "Usersid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JIbadahs_Usersid",
                table: "JIbadahs",
                column: "Usersid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JIbadahs");
        }
    }
}
