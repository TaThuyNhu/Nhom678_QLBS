using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("TheLoai")]
    public partial class TheLoai
    {
        public TheLoai()
        {
            TheLoaiChiTiets = new HashSet<TheLoaiChiTiet>();
        }

        [Key]
        public Guid IdTheLoai { get; set; }
        [Required]
        [StringLength(50)]
        public string MaTheLoai { get; set; }
        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

        [InverseProperty(nameof(TheLoaiChiTiet.IdTheLoaiNavigation))]
        public virtual ICollection<TheLoaiChiTiet> TheLoaiChiTiets { get; set; }
    }
}
