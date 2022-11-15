using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhoService
    {
        string Add(KhoView kho);
        string Delete(KhoView kho);
        string Update(KhoView kho);
        List<KhoView> GetAll();
    }
}
