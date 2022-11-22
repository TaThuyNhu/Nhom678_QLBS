using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Sach")]
    public partial class Sach
    {
        public Sach()
        {
            ChiTietSaches = new HashSet<ChiTietSach>();
        }

        [Key]
        public Guid IdSach { get; set; }
        [Required]
        [StringLength(50)]
        public string MaSach { get; set; }
        [Required]
        [StringLength(100)]
        public string TenSach { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public int AnBan { get; set; }
        [Required]
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayNhap { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuat { get; set; }

        [InverseProperty(nameof(ChiTietSach.IdSachNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
