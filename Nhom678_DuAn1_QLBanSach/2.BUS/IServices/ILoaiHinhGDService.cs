using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiHinhGDService
    {
        string Add(LoaiHinhGiaoDichView lHGDV);
        string Delete(LoaiHinhGiaoDichView lHGDV);
        string Update(LoaiHinhGiaoDichView lHGDV);
        List<LoaiHinhGiaoDichView> GetAll();
    }
}
