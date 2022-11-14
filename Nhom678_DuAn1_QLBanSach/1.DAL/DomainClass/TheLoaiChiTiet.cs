using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("TheLoaiChiTiet")]
    public partial class TheLoaiChiTiet
    {
        public TheLoaiChiTiet()
        {
            ChiTietSaches = new HashSet<ChiTietSach>();
        }

        [Key]
        [StringLength(50)]
        public string MaTheLoaiChiTiet { get; set; }
        [Required]
        [StringLength(50)]
        public string MaTheLoai { get; set; }
        [Required]
        [StringLength(50)]
        public string TenTheLoai { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaTheLoai))]
        [InverseProperty(nameof(TheLoai.TheLoaiChiTiets))]
        public virtual TheLoai MaTheLoaiNavigation { get; set; }
        [InverseProperty(nameof(ChiTietSach.MaTheLoaiChiTietNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
