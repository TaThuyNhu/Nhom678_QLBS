using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonCtView
    {
        public Guid IdHoaDonChiTiet { get; set; }
        public string MaHoaDonChiTiet { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdChiTietSach { get; set; }
        public Guid? IdGiamGia { get; set; }
        public int? GiaGoc { get; set; }
        public int? GiaCuoi { get; set; }
        public string TrangThai { get; set; }

    }
}
