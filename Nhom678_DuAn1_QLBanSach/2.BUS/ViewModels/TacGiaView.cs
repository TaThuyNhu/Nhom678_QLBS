using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class TacGiaView
    {
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string MoTa { get; set; }
        public string Url { get; set; }
    }
}
