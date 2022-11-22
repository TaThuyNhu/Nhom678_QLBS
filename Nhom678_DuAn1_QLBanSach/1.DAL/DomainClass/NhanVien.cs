using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid IdNhanVien { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        public Guid? IdChucVu { get; set; }
        public Guid? IdCuaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        [Required]
        [StringLength(50)]
        public string QueQuan { get; set; }
        public bool GioiTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [ForeignKey(nameof(IdChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdChucVuNavigation { get; set; }
        [ForeignKey(nameof(IdCuaHang))]
        [InverseProperty(nameof(CuaHang.NhanViens))]
        public virtual CuaHang IdCuaHangNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
