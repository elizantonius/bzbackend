using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bzbackend.Migrations
{
    /// <inheritdoc />
    public partial class Role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Roleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Roleid);
                });

            migrationBuilder.CreateTable(
                name: "Sektors",
                columns: table => new
                {
                    Sektorid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sektors", x => x.Sektorid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Usersid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roleid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Usersid);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Roleid",
                        column: x => x.Roleid,
                        principalTable: "Roles",
                        principalColumn: "Roleid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jemaats",
                columns: table => new
                {
                    Jemaatid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alamat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pekerjaan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tglkelahiran = table.Column<DateTime>(type: "datetime2", nullable: false),
                    golongandarah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nokontak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sektorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jemaats", x => x.Jemaatid);
                    table.ForeignKey(
                        name: "FK_Jemaats_Sektors_Sektorid",
                        column: x => x.Sektorid,
                        principalTable: "Sektors",
                        principalColumn: "Sektorid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beritas",
                columns: table => new
                {
                    Beritaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    judul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gambar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tanggal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beritas", x => x.Beritaid);
                    table.ForeignKey(
                        name: "FK_Beritas_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "Usersid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Renungans",
                columns: table => new
                {
                    Renunganid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    judulrenungan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pembacaan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isirenungan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renungans", x => x.Renunganid);
                    table.ForeignKey(
                        name: "FK_Renungans_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "Usersid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beritas_Usersid",
                table: "Beritas",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Jemaats_Sektorid",
                table: "Jemaats",
                column: "Sektorid");

            migrationBuilder.CreateIndex(
                name: "IX_Renungans_Usersid",
                table: "Renungans",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roleid",
                table: "Users",
                column: "Roleid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beritas");

            migrationBuilder.DropTable(
                name: "Jemaats");

            migrationBuilder.DropTable(
                name: "Renungans");

            migrationBuilder.DropTable(
                name: "Sektors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
