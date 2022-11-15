using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICtSachService
    {
        // lam viec chinh 
        string Add(CtSachView ctSachV);
        string Update(CtSachView ctSachV);
        string Delete(CtSachView ctSachV);
        List<CtSachView> GetAll();
    }
}
