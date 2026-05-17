using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MH.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddLichLamViecAndFixIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TienLamThemGio",
                table: "Luong");

            migrationBuilder.AlterColumn<int>(
                name: "MaPhieuThue",
                table: "ThuePhong",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "LichLamViec",
                columns: table => new
                {
                    MaLich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayLamViec = table.Column<DateTime>(type: "date", nullable: false),
                    CaLam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichLamViec", x => x.MaLich);
                    table.ForeignKey(
                        name: "FK_LichLamViec_NhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "Nhanvien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LichLamViec_MaNhanVien",
                table: "LichLamViec",
                column: "MaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichLamViec");

            migrationBuilder.AlterColumn<int>(
                name: "MaPhieuThue",
                table: "ThuePhong",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "TienLamThemGio",
                table: "Luong",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
