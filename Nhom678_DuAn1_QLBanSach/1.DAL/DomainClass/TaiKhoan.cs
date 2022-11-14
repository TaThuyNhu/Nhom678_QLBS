using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string MaTaiKhoan { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
