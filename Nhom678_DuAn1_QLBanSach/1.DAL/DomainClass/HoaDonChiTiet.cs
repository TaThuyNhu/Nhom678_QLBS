using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        public Guid IdHoaDonChiTiet { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoaDonChiTiet { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdChiTietSach { get; set; }
        public Guid? IdGiamGia { get; set; }
        public int? GiaGoc { get; set; }
        public int? GiaCuoi { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [ForeignKey(nameof(IdChiTietSach))]
        [InverseProperty(nameof(ChiTietSach.HoaDonChiTiets))]
        public virtual ChiTietSach IdChiTietSachNavigation { get; set; }
        [ForeignKey(nameof(IdGiamGia))]
        [InverseProperty(nameof(GiamGium.HoaDonChiTiets))]
        public virtual GiamGium IdGiamGiaNavigation { get; set; }
        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}
