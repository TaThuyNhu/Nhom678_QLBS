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
        [StringLength(50)]
        public string MaLoaiGiaoDich { get; set; }
        [Required]
        [StringLength(50)]
        public string MaKhachHang { get; set; }
        [StringLength(50)]
        public string LoaiHinh1 { get; set; }
        [StringLength(50)]
        public string LoaiHinh2 { get; set; }

        [ForeignKey(nameof(MaKhachHang))]
        [InverseProperty(nameof(KhachHang.LoaiHinhGiaoDiches))]
        public virtual KhachHang MaKhachHangNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaLoaiGiaoDichNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
