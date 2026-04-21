using System;
using System.Collections.Generic;
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

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyHotel;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MãChứcVụ);

            entity.ToTable("ChucVu");

            entity.Property(e => e.MãChứcVụ)
                .HasMaxLength(20)
                .HasColumnName("Mã chức vụ");
            entity.Property(e => e.TênChứcVụ)
                .HasMaxLength(50)
                .HasColumnName("Tên chức vụ");
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Luong");

            entity.HasIndex(e => e.MãChứcVụ, "IX_Luong");

            entity.Property(e => e.LươngCơBản)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("[Lương cơ bản");
            entity.Property(e => e.MãChứcVụ)
                .HasMaxLength(20)
                .HasColumnName("Mã Chức Vụ");
            entity.Property(e => e.PhụCấp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Phụ cấp");
            entity.Property(e => e.TiềnLàmThêmGiờ)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Tiền làm thêm giờ");

            entity.HasOne(d => d.MãChứcVụNavigation).WithMany()
                .HasForeignKey(d => d.MãChứcVụ)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Luong_ChucVu");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nhanvien");

            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.ChứcVụ)
                .HasMaxLength(50)
                .HasColumnName("Chức vụ");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GiớiTính)
                .HasMaxLength(10)
                .HasColumnName("Giới tính");
            entity.Property(e => e.LươngCơBản)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Lương cơ bản");
            entity.Property(e => e.MãNhânViên)
                .HasMaxLength(20)
                .HasColumnName("Mã nhân viên");
            entity.Property(e => e.NgàySinh).HasColumnName("Ngày sinh");
            entity.Property(e => e.SốĐiệnThoại)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Số điện thoại");
            entity.Property(e => e.TrạngThái)
                .HasMaxLength(50)
                .HasColumnName("Trạng thái");
            entity.Property(e => e.TênNhânViên)
                .HasMaxLength(100)
                .HasColumnName("Tên nhân viên");
            entity.Property(e => e.ĐịaChỉ)
                .HasMaxLength(255)
                .HasColumnName("Địa chỉ");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TênĐăngNhập);

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TênĐăngNhập)
                .HasMaxLength(50)
                .HasColumnName("Tên đăng nhập");
            entity.Property(e => e.MãChứcVụ)
                .HasMaxLength(20)
                .HasColumnName("Mã chức vụ");
            entity.Property(e => e.MậtKhẩu)
                .HasMaxLength(255)
                .HasColumnName("Mật khẩu");

            entity.HasOne(d => d.MãChứcVụNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MãChứcVụ)
                .HasConstraintName("FK_TaiKhoan_ChucVu");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
