﻿using _1.DAL.DomainClass;
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
        //public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public int TrangThai { get; set; }
        //public string ThanhPho { get; set; }
        //public string QuocGia { get; set; }
    }
}
