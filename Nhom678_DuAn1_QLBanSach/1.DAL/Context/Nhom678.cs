using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class Nhom678 : DbContext
    {
        public Nhom678()
        {
        }

        public Nhom678(DbContextOptions<Nhom678> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietSach> ChiTietSaches { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<GiamGium> GiamGia { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHinhGiaoDich> LoaiHinhGiaoDiches { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TheLoaiChiTiet> TheLoaiChiTiets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=THUYNHU\\SQLEXPRESS;Initial Catalog=Nhom6_DuAn1_IT17304_part2;Persist Security Info=True;User ID=chiuchiu;Password=30062003");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<ChiTietSach>(entity =>
            {
                entity.HasKey(e => e.IdChiTietSach)
                    .HasName("PK__ChiTietS__BCB0D3FC69C5505C");

                entity.Property(e => e.IdChiTietSach).ValueGeneratedNever();

                entity.Property(e => e.MaChiTietSach).IsUnicode(false);

                entity.HasOne(d => d.IdNxbNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdNxb)
                    .HasConstraintName("ChiTietSach_NXB");

                entity.HasOne(d => d.IdSachNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdSach)
                    .HasConstraintName("ChiTietSach_Sach");

                entity.HasOne(d => d.IdTacGiaNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdTacGia)
                    .HasConstraintName("ChiTietSach_TacGia");

                entity.HasOne(d => d.IdTheLoaiChiTietNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.IdTheLoaiChiTiet)
                    .HasConstraintName("ChiTietSach_TheLoaiChiTiet");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdChucVu)
                    .HasName("PK__ChucVu__81D916DF64BBE9B2");

                entity.Property(e => e.IdChucVu).ValueGeneratedNever();

                entity.Property(e => e.MaChucVu).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasKey(e => e.IdCuaHang)
                    .HasName("PK__CuaHang__AFA5D9F88CF38E50");

                entity.Property(e => e.IdCuaHang).ValueGeneratedNever();

                entity.Property(e => e.MaCuaHang).IsUnicode(false);
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.IdGiamGia)
                    .HasName("PK__GiamGia__E0F7D8B6B7B80A42");

                entity.Property(e => e.IdGiamGia).ValueGeneratedNever();

                entity.Property(e => e.MaGiamGia).IsUnicode(false);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK__HoaDon__4DD461C811C84AF8");

                entity.Property(e => e.IdHoaDon).ValueGeneratedNever();

                entity.Property(e => e.MaHoaDon).IsUnicode(false);

                entity.HasOne(d => d.IdLoaiGiaoDichNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdLoaiGiaoDich)
                    .HasConstraintName("HoaDon_LoaiHinhGiaoDich");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("HoaDon_NhanVien");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__B901B359665766AE");

                entity.Property(e => e.IdHoaDonChiTiet).ValueGeneratedNever();

                entity.Property(e => e.MaHoaDonChiTiet).IsUnicode(false);

                entity.HasOne(d => d.IdChiTietSachNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietSach)
                    .HasConstraintName("HoaDonChiTiet_ChiTietSach");

                entity.HasOne(d => d.IdGiamGiaNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdGiamGia)
                    .HasConstraintName("HoaDonChiTiet_GiamGia");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("HoaDonChiTiet_HoaDon");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdKhachHang)
                    .HasName("PK__KhachHan__7CF5D8364F75C6C0");

                entity.Property(e => e.IdKhachHang).ValueGeneratedNever();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.MaKhachHang).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<LoaiHinhGiaoDich>(entity =>
            {
                entity.HasKey(e => e.IdLoaiGiaoDich)
                    .HasName("PK__LoaiHinh__3D9499E8B66CDB37");

                entity.Property(e => e.IdLoaiGiaoDich).ValueGeneratedNever();

                entity.Property(e => e.LoaiHinh1).IsUnicode(false);

                entity.Property(e => e.LoaiHinh2).IsUnicode(false);

                entity.Property(e => e.LoaiHinh3).IsUnicode(false);

                entity.Property(e => e.MaLoaiGiaoDich).IsUnicode(false);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.LoaiHinhGiaoDiches)
                    .HasForeignKey(d => d.IdKhachHang)
                    .HasConstraintName("LoaiHinhGiaoDich_KhachHang");
            });

            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.HasKey(e => e.IdNxb)
                    .HasName("PK__NhaXuatB__0DD2718CF3730370");

                entity.Property(e => e.IdNxb).ValueGeneratedNever();

                entity.Property(e => e.MaNxb).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNhanVien)
                    .HasName("PK__NhanVien__B829484517672A93");

                entity.Property(e => e.IdNhanVien).ValueGeneratedNever();

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.SoDienThoai).IsUnicode(false);

                entity.HasOne(d => d.IdChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdChucVu)
                    .HasConstraintName("NhanVien_ChucVu");

                entity.HasOne(d => d.IdCuaHangNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCuaHang)
                    .HasConstraintName("NhanVien_CuaHang");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.IdSach)
                    .HasName("PK__Sach__A04F60DF79B4C71A");

                entity.Property(e => e.IdSach).ValueGeneratedNever();

                entity.Property(e => e.MaSach).IsUnicode(false);
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.IdTacGia)
                    .HasName("PK__TacGia__E302F0F70474D9D6");

                entity.Property(e => e.IdTacGia).ValueGeneratedNever();

                entity.Property(e => e.MaTacGia).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.IdTheLoai)
                    .HasName("PK__TheLoai__101D8894623BFAF3");

                entity.Property(e => e.IdTheLoai).ValueGeneratedNever();

                entity.Property(e => e.MaTheLoai).IsUnicode(false);
            });

            modelBuilder.Entity<TheLoaiChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdTheLoaiChiTiet)
                    .HasName("PK__TheLoaiC__58C46DF799554B34");

                entity.Property(e => e.IdTheLoaiChiTiet).ValueGeneratedNever();

                entity.Property(e => e.MaTheLoaiChiTiet).IsUnicode(false);

                entity.HasOne(d => d.IdTheLoaiNavigation)
                    .WithMany(p => p.TheLoaiChiTiets)
                    .HasForeignKey(d => d.IdTheLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TheLoaiChiTiet_TheLoai");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
