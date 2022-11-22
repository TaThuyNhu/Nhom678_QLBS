using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietSach")]
    public partial class ChiTietSach
    {
        public ChiTietSach()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        public Guid IdChiTietSach { get; set; }
        [Required]
        [StringLength(50)]
        public string MaChiTietSach { get; set; }
        public Guid? IdTheLoaiChiTiet { get; set; }
        [Column("IdNXB")]
        public Guid? IdNxb { get; set; }
        public Guid? IdTacGia { get; set; }
        public Guid? IdSach { get; set; }
        [StringLength(50)]
        public string TrangThai { get; set; }

        [ForeignKey(nameof(IdNxb))]
        [InverseProperty(nameof(NhaXuatBan.ChiTietSaches))]
        public virtual NhaXuatBan IdNxbNavigation { get; set; }
        [ForeignKey(nameof(IdSach))]
        [InverseProperty(nameof(Sach.ChiTietSaches))]
        public virtual Sach IdSachNavigation { get; set; }
        [ForeignKey(nameof(IdTacGia))]
        [InverseProperty(nameof(TacGium.ChiTietSaches))]
        public virtual TacGium IdTacGiaNavigation { get; set; }
        [ForeignKey(nameof(IdTheLoaiChiTiet))]
        [InverseProperty(nameof(TheLoaiChiTiet.ChiTietSaches))]
        public virtual TheLoaiChiTiet IdTheLoaiChiTietNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdChiTietSachNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
