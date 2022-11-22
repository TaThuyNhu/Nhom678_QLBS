using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid IdChucVu { get; set; }
        [Required]
        [StringLength(50)]
        public string MaChucVu { get; set; }
        [Required]
        [StringLength(50)]
        public string TenChucVu { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [InverseProperty(nameof(NhanVien.IdChucVuNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
