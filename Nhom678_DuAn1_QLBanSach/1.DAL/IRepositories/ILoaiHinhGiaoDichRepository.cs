using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiHinhGiaoDichRepository
    {
        bool AddLoaiHinhGiaoDich(LoaiHinhGiaoDich lh);
        bool UpdateLoaiHinhGiaoDich(LoaiHinhGiaoDich lh);
        bool DeleteLoaiHinhGiaoDich(LoaiHinhGiaoDich lh);
        LoaiHinhGiaoDich GetById(Guid id);
        List<LoaiHinhGiaoDich> GetAllLoaiHinhGiaoDich();

    }
}
