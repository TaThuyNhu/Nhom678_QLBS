using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhaXuatBan")]
    public partial class NhaXuatBan
    {
        public NhaXuatBan()
        {
            ChiTietSaches = new HashSet<ChiTietSach>();
        }

        [Key]
        [Column("IdNXB")]
        public Guid IdNxb { get; set; }
        [Required]
        [Column("MaNXB")]
        [StringLength(50)]
        public string MaNxb { get; set; }
        [Required]
        [Column("TenNXB")]
        [StringLength(50)]
        public string TenNxb { get; set; }
        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }
        [Required]
        [Column("URL")]
        [StringLength(50)]
        public string Url { get; set; }

        [InverseProperty(nameof(ChiTietSach.IdNxbNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
