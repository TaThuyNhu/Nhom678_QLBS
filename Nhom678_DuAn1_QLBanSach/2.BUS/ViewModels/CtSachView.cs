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
    public class CtSachView
    {
        public string MaChiTietSach { get; set; }
        public string MaTheLoaiChiTiet { get; set; }
        public string MaNxb { get; set; }
        public string MaTacGia { get; set; }
        public string MaSach { get; set; }
        public string MaKho { get; set; }
        public string TrangThai { get; set; }

    }
}
