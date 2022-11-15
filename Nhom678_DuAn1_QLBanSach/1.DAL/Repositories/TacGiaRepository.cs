using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class TacGiaRepository : ITacGiaRepository
    {
        private Nhom678 _dBContext;
        List<TacGium>  tacGia;
        public TacGiaRepository()
        {
            _dBContext = new Nhom678();
            tacGia = new List<TacGium>();
        }
        public bool AddTacGia(TacGium tg)
        {
            if (tg == null) return false;
            _dBContext.TacGia.Add(tg);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteTacGia(TacGium tg)
        {
            if (tg == null) return false;
            var temp = _dBContext.TacGia.FirstOrDefault(c => c.MaTacGia == tg.MaTacGia);
            _dBContext.TacGia.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<TacGium> GetAllTacGia()
        {
            tacGia = _dBContext.TacGia.ToList();
            return tacGia;
        }

        public TacGium GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTacGia(TacGium tg)
        {
            if (tg == null) return false;
            var temp = _dBContext.TacGia.FirstOrDefault(c => c.MaTacGia == tg.MaTacGia);
            _dBContext.TacGia.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
