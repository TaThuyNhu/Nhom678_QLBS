using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietSach")]
    public partial class ChiTietSach
    {
        public ChiTietSach()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string MaChiTietSach { get; set; }
        [StringLength(50)]
        public string MaTheLoaiChiTiet { get; set; }
        [Column("MaNXB")]
        [StringLength(50)]
        public string MaNxb { get; set; }
        [StringLength(50)]
        public string MaTacGia { get; set; }
        [StringLength(50)]
        public string MaSach { get; set; }
        [StringLength(50)]
        public string MaKho { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [ForeignKey(nameof(MaKho))]
        [InverseProperty(nameof(Kho.ChiTietSaches))]
        public virtual Kho MaKhoNavigation { get; set; }
        [ForeignKey(nameof(MaNxb))]
        [InverseProperty(nameof(NhaXuatBan.ChiTietSaches))]
        public virtual NhaXuatBan MaNxbNavigation { get; set; }
        [ForeignKey(nameof(MaSach))]
        [InverseProperty(nameof(Sach.ChiTietSaches))]
        public virtual Sach MaSachNavigation { get; set; }
        [ForeignKey(nameof(MaTacGia))]
        [InverseProperty(nameof(TacGium.ChiTietSaches))]
        public virtual TacGium MaTacGiaNavigation { get; set; }
        [ForeignKey(nameof(MaTheLoaiChiTiet))]
        [InverseProperty(nameof(TheLoaiChiTiet.ChiTietSaches))]
        public virtual TheLoaiChiTiet MaTheLoaiChiTietNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaChiTietSachNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
