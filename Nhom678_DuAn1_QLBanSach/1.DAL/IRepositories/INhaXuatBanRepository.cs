using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhaXuatBanRepository
    {
        bool AddNhaXuatBan(NhaXuatBan nxb);
        bool UpdateNhaXuatBan(NhaXuatBan nxb);
        bool DeleteNhaXuatBan(NhaXuatBan nxb);
        NhaXuatBan GetById(Guid id);
        List<NhaXuatBan> GetAllNhaXuatBan();

    }
}
