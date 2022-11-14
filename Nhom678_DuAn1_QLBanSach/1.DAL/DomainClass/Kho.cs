using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Kho")]
    public partial class Kho
    {
        public Kho()
        {
            ChiTietSaches = new HashSet<ChiTietSach>();
        }

        [Key]
        [StringLength(50)]
        public string MaKho { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayNhap { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuat { get; set; }
        public int? SoLuongConLai { get; set; }

        [InverseProperty(nameof(ChiTietSach.MaKhoNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
