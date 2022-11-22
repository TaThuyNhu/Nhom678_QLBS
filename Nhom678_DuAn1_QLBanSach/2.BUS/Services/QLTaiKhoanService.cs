//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using _1.DAL.Repositories;
//using _2.BUS.IServices;
//using _2.BUS.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2.BUS.Services
//{
//    public class QLTaiKhoanService : ITaiKhoanService
//    {
//        private ITaiKhoanRepository TaiKhoanRepository;
//        public QLTaiKhoanService()
//        {
//            TaiKhoanRepository = new TaiKhoanRepository();
//        }
//        public string Add(TaiKhoanView tkV)
//        {
//            if (tkV == null) return "Them khong thanh cong";
//            var khohang = new TaiKhoan()
//            {
//                MaTaiKhoan = tkV.MaTaiKhoan,
//                MatKhau = tkV.MatKhau,
//            };
//            if (TaiKhoanRepository.AddTaiKhoan(khohang))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(TaiKhoanView tkV)
//        {
//            if (tkV == null) return "xoa khong thanh cong";
//            var khohang = new TaiKhoan()
//            {
//                MaTaiKhoan = tkV.MaTaiKhoan,
//                MatKhau = tkV.MatKhau,
//            };
//            if (TaiKhoanRepository.DeleteTaiKhoan(khohang))
//                return "xoa thanh cong";
//            return "xoa khong thanh cong";
//        }

//        public List<TaiKhoanView> GetAll()
//        {
//            List<TaiKhoanView> list = new List<TaiKhoanView>();
//            list = (from n in TaiKhoanRepository.GetAllTaiKhoan()
//                    select new TaiKhoanView
//                    {
//                        MaNhanVien = n.MaNhanVien,
//                        MaTaiKhoan = n.MaTaiKhoan,
//                        MatKhau = n.MatKhau
//                    }).ToList();
//            return list;
//        }

//        public string Update(TaiKhoanView tkV)
//        {
//            if (tkV == null) return "sua khong thanh cong";
//            var khohang = new TaiKhoan()
//            {
//                MaTaiKhoan = tkV.MaTaiKhoan,
//                MatKhau = tkV.MatKhau,             
//            };
//            if (TaiKhoanRepository.UpdateTaiKhoan(khohang))
//                return "sua thanh cong";
//            return "sua khong thanh cong";
//        }
//    }
//}
