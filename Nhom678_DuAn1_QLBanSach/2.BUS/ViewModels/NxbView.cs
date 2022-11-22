using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class NxbView
    {
        public Guid IdNxb { get; set; }
        public string MaNxb { get; set; }
        public string TenNxb { get; set; }
        public string DiaChi { get; set; }
        public string Url { get; set; }
    }
}
