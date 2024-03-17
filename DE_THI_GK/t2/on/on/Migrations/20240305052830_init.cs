using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace on.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nhaxuatban",
                columns: table => new
                {
                    manxb = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    tennxb = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dienthoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaxuatban", x => x.manxb);
                });

            migrationBuilder.CreateTable(
                name: "tacgia",
                columns: table => new
                {
                    matg = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    tentg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngaysinh = table.Column<DateTime>(type: "date", nullable: true),
                    phai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tacgia", x => x.matg);
                });

            migrationBuilder.CreateTable(
                name: "sach",
                columns: table => new
                {
                    masach = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tensach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    theloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    namxb = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    manxb = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sach", x => x.masach);
                    table.ForeignKey(
                        name: "FK_sach_nhaxuatban",
                        column: x => x.manxb,
                        principalTable: "nhaxuatban",
                        principalColumn: "manxb");
                });

            migrationBuilder.CreateTable(
                name: "chitietSach_Tacgia",
                columns: table => new
                {
                    masach = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    matg = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitietSach_Tacgia", x => new { x.masach, x.matg });
                    table.ForeignKey(
                        name: "FK_chitietSach_Tacgia_sach",
                        column: x => x.masach,
                        principalTable: "sach",
                        principalColumn: "masach");
                    table.ForeignKey(
                        name: "FK_chitietSach_Tacgia_tacgia",
                        column: x => x.matg,
                        principalTable: "tacgia",
                        principalColumn: "matg");
                });

            migrationBuilder.CreateIndex(
                name: "IX_chitietSach_Tacgia_matg",
                table: "chitietSach_Tacgia",
                column: "matg");

            migrationBuilder.CreateIndex(
                name: "IX_sach_manxb",
                table: "sach",
                column: "manxb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chitietSach_Tacgia");

            migrationBuilder.DropTable(
                name: "sach");

            migrationBuilder.DropTable(
                name: "tacgia");

            migrationBuilder.DropTable(
                name: "nhaxuatban");
        }
    }
}
