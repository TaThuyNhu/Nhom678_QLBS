using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LoaiHinhGiaoDichRepository : ILoaiHinhGiaoDichRepository
    {
        private Nhom678 _dBContext;
        List<LoaiHinhGiaoDich> _LoaiHinhGiaoDichList;
        public LoaiHinhGiaoDichRepository()
        {
            _dBContext = new Nhom678();
            _LoaiHinhGiaoDichList = new List<LoaiHinhGiaoDich>();
        }

        public bool AddLoaiHinhGiaoDich(LoaiHinhGiaoDich lh)
        {
            if (lh == null) return false;
            _dBContext.LoaiHinhGiaoDiches.Add(lh);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteLoaiHinhGiaoDich(LoaiHinhGiaoDich lh)
        {
            if (lh == null) return false;
            var temp = _dBContext.LoaiHinhGiaoDiches.FirstOrDefault(c => c.MaLoaiGiaoDich == lh.MaLoaiGiaoDich);
            _dBContext.LoaiHinhGiaoDiches.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<LoaiHinhGiaoDich> GetAllLoaiHinhGiaoDich()
        {
            _LoaiHinhGiaoDichList = _dBContext.LoaiHinhGiaoDiches.ToList();
            return _LoaiHinhGiaoDichList;
        }

        public LoaiHinhGiaoDich GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLoaiHinhGiaoDich(LoaiHinhGiaoDich lh)
        {
            if (lh == null) return false;
            var temp = _dBContext.LoaiHinhGiaoDiches.FirstOrDefault(c => c.MaLoaiGiaoDich == lh.MaLoaiGiaoDich);
            _dBContext.LoaiHinhGiaoDiches.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
