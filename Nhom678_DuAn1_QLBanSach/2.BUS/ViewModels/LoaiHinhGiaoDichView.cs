using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class LoaiHinhGiaoDichView
    {
        public Guid IdLoaiGiaoDich { get; set; }
        public string MaLoaiGiaoDich { get; set; }
        public Guid? IdKhachHang { get; set; }
        public string LoaiHinh1 { get; set; }
        public string LoaiHinh2 { get; set; }
        public string LoaiHinh3 { get; set; }
    }
}
