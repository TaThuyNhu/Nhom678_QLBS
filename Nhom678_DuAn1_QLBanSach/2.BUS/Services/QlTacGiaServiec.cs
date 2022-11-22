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
        {c
            if (tgV == null) return "Thêm không thành công ";
            var khohang = new TacGium()
            {
                IdTacGia = tgV.IdTacGia,
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.AddTacGia(khohang))
                return "Thêm thành công ";
            return "Thêm không thành công ";
        }

        public string Delete(TacGiaView tgV)
        {
            if (tgV == null) return "Xóa không thành công";
            var khohang = new TacGium()
            {
                IdTacGia = tgV.IdTacGia,
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.DeleteTacGia(khohang))
                return "Xóa thành công";
            return "Xóa không thành côngg";
        }

        public List<TacGiaView> GetAll()
        {
            List<TacGiaView> list = new List<TacGiaView>();
            list = (from a in tacGiaRepository.GetAllTacGia()
                    select new TacGiaView
                    {
                        IdTacGia=a.IdTacGia,
                        MaTacGia = a.MaTacGia,
                        TenTacGia = a.TenTacGia,
                        MoTa = a.MoTa,
                        Url = a.Url,
                    }).ToList();
            return list;
        }

        public string Update(TacGiaView tgV)
        {
            if (tgV == null) return "Sửa không thành công";
            var khohang = new TacGium()
            {
                IdTacGia = tgV.IdTacGia,
                MaTacGia = tgV.MaTacGia,
                TenTacGia = tgV.TenTacGia,
                MoTa = tgV.MoTa,
                Url = tgV.Url,
            };
            if (tacGiaRepository.UpdateTacGia(khohang))
                return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
