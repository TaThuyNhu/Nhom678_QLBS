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
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<LoaiHinhGiaoDich> LoaiHinhGiaoDiches { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TacGium> TacGia { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
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
                entity.HasKey(e => e.MaChiTietSach)
                    .HasName("PK__ChiTietS__1B9805A1A6473CA7");

                entity.Property(e => e.MaChiTietSach).IsUnicode(false);

                entity.Property(e => e.MaKho).IsUnicode(false);

                entity.Property(e => e.MaNxb).IsUnicode(false);

                entity.Property(e => e.MaSach).IsUnicode(false);

                entity.Property(e => e.MaTacGia).IsUnicode(false);

                entity.Property(e => e.MaTheLoaiChiTiet).IsUnicode(false);

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.MaKho)
                    .HasConstraintName("FK__ChiTietSa__MaKho__6383C8BA");

                entity.HasOne(d => d.MaNxbNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.MaNxb)
                    .HasConstraintName("FK__ChiTietSa__MaNXB__60A75C0F");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.MaSach)
                    .HasConstraintName("FK__ChiTietSa__MaSac__628FA481");

                entity.HasOne(d => d.MaTacGiaNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.MaTacGia)
                    .HasConstraintName("FK__ChiTietSa__MaTac__619B8048");

                entity.HasOne(d => d.MaTheLoaiChiTietNavigation)
                    .WithMany(p => p.ChiTietSaches)
                    .HasForeignKey(d => d.MaTheLoaiChiTiet)
                    .HasConstraintName("FK__ChiTietSa__MaThe__5FB337D6");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaCv)
                    .HasName("PK__ChucVu__27258E76F9A40884");

                entity.Property(e => e.MaCv).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasKey(e => e.MaCh)
                    .HasName("PK__CuaHang__27258E00E9A4B01A");

                entity.Property(e => e.MaCh).IsUnicode(false);
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.MaGg)
                    .HasName("PK__GiamGia__2725AE82D7449CAF");

                entity.Property(e => e.MaGg).IsUnicode(false);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13BF59DB083");

                entity.Property(e => e.MaHoaDon).IsUnicode(false);

                entity.Property(e => e.MaLoaiGiaoDich).IsUnicode(false);

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.HasOne(d => d.MaLoaiGiaoDichNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaLoaiGiaoDich)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaLoaiGi__5BE2A6F2");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__5CD6CB2B");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__6C2FD0CEDF1966AD");

                entity.Property(e => e.MaHoaDonChiTiet).IsUnicode(false);

                entity.Property(e => e.MaChiTietSach).IsUnicode(false);

                entity.Property(e => e.MaGiamGia).IsUnicode(false);

                entity.Property(e => e.MaHoaDon).IsUnicode(false);

                entity.HasOne(d => d.MaChiTietSachNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaChiTietSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaChi__59063A47");

                entity.HasOne(d => d.MaGiamGiaNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaGiamGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaGia__59FA5E80");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaHoa__5812160E");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E5EBF3C51D");

                entity.Property(e => e.MaKhachHang).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.HasKey(e => e.MaKho)
                    .HasName("PK__Kho__3BDA93508D256BBD");

                entity.Property(e => e.MaKho).IsUnicode(false);
            });

            modelBuilder.Entity<LoaiHinhGiaoDich>(entity =>
            {
                entity.HasKey(e => e.MaLoaiGiaoDich)
                    .HasName("PK__LoaiHinh__28EE2A2FB090965D");

                entity.Property(e => e.MaLoaiGiaoDich).IsUnicode(false);

                entity.Property(e => e.LoaiHinh1).IsUnicode(false);

                entity.Property(e => e.LoaiHinh2).IsUnicode(false);

                entity.Property(e => e.MaKhachHang).IsUnicode(false);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.LoaiHinhGiaoDiches)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoaiHinhG__MaKha__5AEE82B9");
            });

            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.HasKey(e => e.MaNxb)
                    .HasName("PK__NhaXuatB__3A19482C6767EAA7");

                entity.Property(e => e.MaNxb).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA4736266C0C");

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.Property(e => e.MaCh).IsUnicode(false);

                entity.Property(e => e.MaChucVu).IsUnicode(false);

                entity.Property(e => e.SoDienThoai).IsUnicode(false);

                entity.HasOne(d => d.MaChNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaCh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaCH__5DCAEF64");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaChuc__5EBF139D");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__Sach__B235742D8E6DFE89");

                entity.Property(e => e.MaSach).IsUnicode(false);
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.MaTacGia)
                    .HasName("PK__TacGia__F24E67569449ECEA");

                entity.Property(e => e.MaTacGia).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__TaiKhoan__AD7C65291F197673");

                entity.Property(e => e.MaTaiKhoan).IsUnicode(false);

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__TheLoai__D73FF34AC62D1AD4");

                entity.Property(e => e.MaTheLoai).IsUnicode(false);
            });

            modelBuilder.Entity<TheLoaiChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaTheLoaiChiTiet)
                    .HasName("PK__TheLoaiC__7B2AE26BD7FF1BC0");

                entity.Property(e => e.MaTheLoaiChiTiet).IsUnicode(false);

                entity.Property(e => e.MaTheLoai).IsUnicode(false);

                entity.HasOne(d => d.MaTheLoaiNavigation)
                    .WithMany(p => p.TheLoaiChiTiets)
                    .HasForeignKey(d => d.MaTheLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheLoaiCh__MaThe__6477ECF3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
