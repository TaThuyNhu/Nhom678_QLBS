using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class CuaHangView
    {
        public Guid IdCuaHang { get; set; }
        public string MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }
    }
}
