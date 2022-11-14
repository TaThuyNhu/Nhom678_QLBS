﻿using System;
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
        [StringLength(50)]
        public string MaSach { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public int AnBan { get; set; }
        [Required]
        [StringLength(50)]
        public string MoTa { get; set; }

        [InverseProperty(nameof(ChiTietSach.MaSachNavigation))]
        public virtual ICollection<ChiTietSach> ChiTietSaches { get; set; }
    }
}
