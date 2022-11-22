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
    public class SachView
    {
        public Guid IdSach { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public int AnBan { get; set; }
        public string MoTa { get; set; }
        public int? SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayXuat { get; set; }

    }
}
