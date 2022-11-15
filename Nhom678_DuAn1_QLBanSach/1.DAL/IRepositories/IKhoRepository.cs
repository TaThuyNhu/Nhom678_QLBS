using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhoRepository
    {
        bool AddKho(Kho k);
        bool UpdateKho(Kho k);
        bool DeleteKho(Kho k);
        Kho GetById(Guid Ma);
        List<Kho> GetAllKho();

    }
}
