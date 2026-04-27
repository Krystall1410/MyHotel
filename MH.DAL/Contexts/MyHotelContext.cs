using MH.Domain.entities;
using Microsoft.EntityFrameworkCore;

namespace MH.DAL.Models;

public partial class MyHotelContext : DbContext
{
    public MyHotelContext()
    {
    }

    public MyHotelContext(DbContextOptions<MyHotelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phong> Phongs { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThuePhong> ThuePhongs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MyHotel;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaChucVu);

            entity.ToTable("ChucVu");

            entity.Property(e => e.MaChucVu).HasMaxLength(20);
            entity.Property(e => e.TenChucVu).HasMaxLength(50);
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang);

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKhachHang).HasMaxLength(20);
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .HasColumnName("CCCD");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
        });

        modelBuilder.Entity<LoaiPhong>(entity =>
        {
            entity.HasKey(e => e.MaLoai);

            entity.ToTable("LoaiPhong");

            entity.Property(e => e.MaLoai).HasMaxLength(20);
            entity.Property(e => e.GiaGoc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Luong");

            entity.HasIndex(e => e.MaChucVu, "IX_Luong");

            entity.Property(e => e.LuongCoBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaChucVu).HasMaxLength(20);
            entity.Property(e => e.PhuCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TienLamThemGio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany()
                .HasForeignKey(d => d.MaChucVu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Luong_ChucVu");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK_nhanvien");

            entity.ToTable("Nhanvien");

            entity.Property(e => e.MaNhanVien).HasMaxLength(20);
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.LuongCoBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasMaxLength(50);
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.MaPhong);

            entity.ToTable("Phong");

            entity.Property(e => e.MaPhong).HasMaxLength(20);
            entity.Property(e => e.MaLoai).HasMaxLength(20);
            entity.Property(e => e.SoPhong).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.Phongs)
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Phong_LoaiPhong");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap);

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
            entity.Property(e => e.MaChucVu).HasMaxLength(20);
            entity.Property(e => e.MatKhau).HasMaxLength(255);

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaChucVu)
                .HasConstraintName("FK_MaChucVu");
        });

        modelBuilder.Entity<ThuePhong>(entity =>
        {
            entity.HasKey(e => e.MaPhieuThue).HasName("PK_ThuPhong");

            entity.ToTable("ThuePhong");

            entity.Property(e => e.MaPhieuThue).ValueGeneratedNever();
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.GioCheckIn).HasColumnType("datetime");
            entity.Property(e => e.GioCheckOut).HasColumnType("datetime");
            entity.Property(e => e.GioCheckOutThucTe).HasColumnType("datetime");
            entity.Property(e => e.MaKhachHang).HasMaxLength(20);
            entity.Property(e => e.MaNhanVien).HasMaxLength(20);
            entity.Property(e => e.MaPhong).HasMaxLength(20);
            entity.Property(e => e.TienCoc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThaiThanhToan).HasMaxLength(50);

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.ThuePhongs)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("makhachhang");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.ThuePhongs)
                .HasForeignKey(d => d.MaNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_manhanvien");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.ThuePhongs)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("maphong");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
