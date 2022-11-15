using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSachRepository
    {
        bool AddChiTietSach(ChiTietSach cts);
        bool UpdateChiTietSach(ChiTietSach cts);
        bool DeleteChiTietSach(ChiTietSach cts);
        ChiTietSach GetById(Guid id);
        List<ChiTietSach> GetAllChiTietSach();

    }
}
