using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class Atık_Oto_Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    Yetkiler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MevcutGorev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonGirisZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
