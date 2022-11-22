using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class NhanVienView
    {
        public Guid IdNhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public Guid? IdChucVu { get; set; }
        public Guid? IdCuaHang { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string QueQuan { get; set; }
        public bool GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string TrangThai { get; set; }
        public string MatKhau { get; set; }

    }
}
