using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bzbackend.Migrations
{
    /// <inheritdoc />
    public partial class updatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beritas_Users_Usersid",
                table: "Beritas");

            migrationBuilder.DropForeignKey(
                name: "FK_Jemaats_Sektors_Sektorid",
                table: "Jemaats");

            migrationBuilder.DropForeignKey(
                name: "FK_JIbadahs_Users_Usersid",
                table: "JIbadahs");

            migrationBuilder.DropForeignKey(
                name: "FK_Renungans_Users_Usersid",
                table: "Renungans");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Roleid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Renungans_Usersid",
                table: "Renungans");

            migrationBuilder.DropIndex(
                name: "IX_JIbadahs_Usersid",
                table: "JIbadahs");

            migrationBuilder.DropIndex(
                name: "IX_Jemaats_Sektorid",
                table: "Jemaats");

            migrationBuilder.DropIndex(
                name: "IX_Beritas_Usersid",
                table: "Beritas");

            migrationBuilder.CreateTable(
                name: "KepalaKeluargas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    namalengkap = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nik = table.Column<int>(type: "int", nullable: false),
                    jeniskelamin = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tempatlahir = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tangallahir = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    pendidikan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jenispekerjaan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    golongandarah = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statusperkawinan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statusdalamkeluarga = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    baptis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sidi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KepalaKeluargas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LiturgiIbadahs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    liturgi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bacaan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PemimpinIbadah = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pendamping = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PengakuanDosa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pembacaan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PembacaWJ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PelayanaanOS = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kolektaan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PemainKeyboard = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nyanyian = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MajelisPiket = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiturgiIbadahs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KepalaKeluargas");

            migrationBuilder.DropTable(
                name: "LiturgiIbadahs");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roleid",
                table: "Users",
                column: "Roleid");

            migrationBuilder.CreateIndex(
                name: "IX_Renungans_Usersid",
                table: "Renungans",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_JIbadahs_Usersid",
                table: "JIbadahs",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Jemaats_Sektorid",
                table: "Jemaats",
                column: "Sektorid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beritas_Usersid",
                table: "Beritas",
                column: "Usersid");

            migrationBuilder.AddForeignKey(
                name: "FK_Beritas_Users_Usersid",
                table: "Beritas",
                column: "Usersid",
                principalTable: "Users",
                principalColumn: "Usersid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jemaats_Sektors_Sektorid",
                table: "Jemaats",
                column: "Sektorid",
                principalTable: "Sektors",
                principalColumn: "Sektorid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JIbadahs_Users_Usersid",
                table: "JIbadahs",
                column: "Usersid",
                principalTable: "Users",
                principalColumn: "Usersid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Renungans_Users_Usersid",
                table: "Renungans",
                column: "Usersid",
                principalTable: "Users",
                principalColumn: "Usersid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users",
                column: "Roleid",
                principalTable: "Roles",
                principalColumn: "Roleid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
