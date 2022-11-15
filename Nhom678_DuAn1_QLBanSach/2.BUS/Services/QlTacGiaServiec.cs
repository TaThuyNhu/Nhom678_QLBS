using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QlTacGiaServiec : ITacGiaService
    {

        private ITacGiaRepository tacGiaRepository;
        public QlTacGiaServiec()
        {
            tacGiaRepository = new TacGiaRepository();
        }
        public string Add(TacGiaView tgV)
        {
            if (tgV == null) return "Them khong thanh cong";
            var khohang = new TacGium()
            {
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.AddTacGia(khohang))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(TacGiaView tgV)
        {
            if (tgV == null) return "xoa khong thanh cong";
            var khohang = new TacGium()
            {
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.DeleteTacGia(khohang))
                return "xoa thanh cong";
            return "xoa khong thanh cong";
        }

        public List<TacGiaView> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(TacGiaView tgV)
        {
            if (tgV == null) return "sua khong thanh cong";
            var khohang = new TacGium()
            {
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.UpdateTacGia(khohang))
                return "sua thanh cong";
            return "sua khong thanh cong";
        }
    }
}
