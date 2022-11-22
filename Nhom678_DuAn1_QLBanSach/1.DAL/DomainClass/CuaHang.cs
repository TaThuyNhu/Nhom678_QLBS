using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("CuaHang")]
    public partial class CuaHang
    {
        public CuaHang()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid IdCuaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string MaCuaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string TenCuaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [InverseProperty(nameof(NhanVien.IdCuaHangNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
