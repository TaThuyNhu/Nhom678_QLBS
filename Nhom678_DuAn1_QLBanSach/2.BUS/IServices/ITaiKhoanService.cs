using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITaiKhoanService
    {
        string Add(TaiKhoanView tkV);
        string Delete(TaiKhoanView tkV);
        string Update(TaiKhoanView tkV);
        List<TaiKhoanView> GetAll();
    }
}
