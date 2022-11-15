using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITacGiaService
    {
        string Add(TacGiaView tgV);
        string Delete(TacGiaView tgV);
        string Update(TacGiaView tgV);
        List<TacGiaView> GetAll();
    }
}
