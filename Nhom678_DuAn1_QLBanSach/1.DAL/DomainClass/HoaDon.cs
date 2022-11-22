using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid IdHoaDon { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        public Guid? IdLoaiGiaoDich { get; set; }
        public Guid? IdNhanVien { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayTaoDon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayShip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayNhan { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [ForeignKey(nameof(IdLoaiGiaoDich))]
        [InverseProperty(nameof(LoaiHinhGiaoDich.HoaDons))]
        public virtual LoaiHinhGiaoDich IdLoaiGiaoDichNavigation { get; set; }
        [ForeignKey(nameof(IdNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNhanVienNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
