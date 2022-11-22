using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class TheLoaiView
    {
        public Guid IdTheLoai { get; set; }
        public string MaTheLoai { get; set; }
        public string MoTa { get; set; }

    }
}
