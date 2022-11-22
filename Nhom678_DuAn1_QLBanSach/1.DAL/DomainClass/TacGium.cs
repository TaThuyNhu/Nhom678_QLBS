using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    public partial class TacGium
    {
        public TacGium()
        {
            ChiTietSaches = new HashSet<ChiTietSach>();
        }

        [Key]
        public Guid IdTacGia { get; set; }
        [Required]
        [StringLength(50)]
        public string MaTacGia { get; set; }
        [Required]
        [StringLength(50)]
        public string TenTacGia { get; set; }
        [Required]
        [StringLength(50)]
        public string MoTa { get; set; }
        [Required]
        [Column("URL")]
        [StringLength(50)]
        public string Url { get; set; }

        [InverseProperty(nameof(ChiTietSach.IdTacGiaNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
