using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            LoaiHinhGiaoDiches = new HashSet<LoaiHinhGiaoDich>();
        }

        [Key]
        public Guid IdKhachHang { get; set; }
        [Required]
        [StringLength(50)]
        public string MaKhachHang { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }
        [Required]
        [StringLength(50)]
        public string Sdt { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [InverseProperty(nameof(LoaiHinhGiaoDich.IdKhachHangNavigation))]
        public virtual ICollection<LoaiHinhGiaoDich> LoaiHinhGiaoDiches { get; set; }
    }
}
