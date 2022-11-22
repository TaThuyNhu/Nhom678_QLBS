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
        public Guid IdChiTietSach { get; set; }
        public string MaChiTietSach { get; set; }
        public Guid? IdTheLoaiChiTiet { get; set; }
        public Guid? IdNxb { get; set; }
        public Guid? IdTacGia { get; set; }
        public Guid? IdSach { get; set; }
        public string TrangThai { get; set; }


    }
}
