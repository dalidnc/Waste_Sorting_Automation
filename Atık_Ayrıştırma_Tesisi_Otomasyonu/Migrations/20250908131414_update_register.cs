using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atık_Ayrıştırma_Tesisi_Otomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class update_register : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Yetkiler",
                table: "employees",
                newName: "Telefon");

            migrationBuilder.RenameColumn(
                name: "SonGirisZamani",
                table: "employees",
                newName: "UyeOlmaTarihi");

            migrationBuilder.RenameColumn(
                name: "Sifre",
                table: "employees",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Pozisyon",
                table: "employees",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "MevcutGorev",
                table: "employees",
                newName: "GorevAlani");

            migrationBuilder.RenameColumn(
                name: "KullaniciAdi",
                table: "employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "IseGirisTarihi",
                table: "employees",
                newName: "DogumTarihi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UyeOlmaTarihi",
                table: "employees",
                newName: "SonGirisZamani");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "employees",
                newName: "Yetkiler");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "employees",
                newName: "Sifre");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "employees",
                newName: "Pozisyon");

            migrationBuilder.RenameColumn(
                name: "GorevAlani",
                table: "employees",
                newName: "MevcutGorev");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "employees",
                newName: "KullaniciAdi");

            migrationBuilder.RenameColumn(
                name: "DogumTarihi",
                table: "employees",
                newName: "IseGirisTarihi");
        }
    }
}
