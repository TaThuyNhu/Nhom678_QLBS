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
    public class HoaDonView
    {
        public Guid IdHoaDon { get; set; }
        public string MaHoaDon { get; set; }
        public Guid? IdLoaiGiaoDich { get; set; }
        public Guid? IdNhanVien { get; set; }
        public DateTime NgayTaoDon { get; set; }
        public DateTime NgayShip { get; set; }
        public DateTime NgayNhan { get; set; }
        public string TrangThai { get; set; }
    }
}
