using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITacGiaRepository
    {
        bool AddTacGia(TacGium tg);
        bool UpdateTacGia(TacGium tg);
        bool DeleteTacGia(TacGium tg);
        TacGium GetById(Guid Ma);
        List<TacGium> GetAllTacGia();

    }
}
