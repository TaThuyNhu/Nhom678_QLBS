using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class TheLoaiCtView
    {
        public Guid IdTheLoaiChiTiet { get; set; }
        public string MaTheLoaiChiTiet { get; set; }
        public Guid IdTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public int? TrangThai { get; set; }

    }
}
