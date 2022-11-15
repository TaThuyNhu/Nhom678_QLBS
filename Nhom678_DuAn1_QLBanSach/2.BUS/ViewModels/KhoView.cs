using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KhoView
    {
        public string MaKho { get; set; }
        public int? SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayXuat { get; set; }
        public int? SoLuongConLai { get; set; }
    }
}
