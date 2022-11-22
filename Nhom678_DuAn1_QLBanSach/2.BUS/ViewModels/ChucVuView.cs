using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ChucVuView
    {
        public Guid IdChucVu { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string TrangThai { get; set; }
    }
}
