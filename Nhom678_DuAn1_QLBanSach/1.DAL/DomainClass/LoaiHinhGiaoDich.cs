using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("LoaiHinhGiaoDich")]
    public partial class LoaiHinhGiaoDich
    {
        public LoaiHinhGiaoDich()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid IdLoaiGiaoDich { get; set; }
        [Required]
        [StringLength(50)]
        public string MaLoaiGiaoDich { get; set; }
        public Guid? IdKhachHang { get; set; }
        [StringLength(50)]
        public string LoaiHinh1 { get; set; }
        [StringLength(50)]
        public string LoaiHinh2 { get; set; }
        [StringLength(50)]
        public string LoaiHinh3 { get; set; }

        [ForeignKey(nameof(IdKhachHang))]
        [InverseProperty(nameof(KhachHang.LoaiHinhGiaoDiches))]
        public virtual KhachHang IdKhachHangNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdLoaiGiaoDichNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
