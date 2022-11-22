//using _1.DAL.Context;
//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Repositories
//{
//    public class TaiKhoanRepository : ITaiKhoanRepository
//    {
//        private Nhom678 _dBContext;
//        List<TaiKhoan> _TaiKhoanList;
//        public TaiKhoanRepository()
//        {
//            _dBContext = new Nhom678();
//            _TaiKhoanList = new List<TaiKhoan>();
//        }
//        public bool AddTaiKhoan(TaiKhoan tk)
//        {
//            if (tk == null) return false;
//            _dBContext.TaiKhoans.Add(tk);
//            _dBContext.SaveChanges();
//            return true;
//        }

//        public bool DeleteTaiKhoan(TaiKhoan tk)
//        {
//            if (tk == null) return false;
//            var temp = _dBContext.TaiKhoans.FirstOrDefault(c => c.MaTaiKhoan == tk.MaTaiKhoan);
//            _dBContext.TaiKhoans.Remove(temp);
//            _dBContext.SaveChanges();
//            return true;
//        }

//        public List<TaiKhoan> GetAllTaiKhoan()
//        {
//            _TaiKhoanList = _dBContext.TaiKhoans.ToList();
//            return _TaiKhoanList;
//        }

//        public TaiKhoan GetById(Guid Ma)
//        {
//            throw new NotImplementedException();
//        }

//        public bool UpdateTaiKhoan(TaiKhoan tk)
//        {
//            if (tk == null) return false;
//            var temp = _dBContext.TaiKhoans.FirstOrDefault(c => c.MaTaiKhoan == tk.MaTaiKhoan);
//            _dBContext.TaiKhoans.Update(temp);
//            _dBContext.SaveChanges();
//            return true;
//        }
//    }
//}
