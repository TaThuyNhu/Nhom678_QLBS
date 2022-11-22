using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid IdGiamGia { get; set; }
        [Required]
        [StringLength(50)]
        public string MaGiamGia { get; set; }
        [Required]
        [Column("DoiTuongGG")]
        [StringLength(50)]
        public string DoiTuongGg { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ThoiHan { get; set; }
        public double PhanTram { get; set; }

        [InverseProperty(nameof(HoaDonChiTiet.IdGiamGiaNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
