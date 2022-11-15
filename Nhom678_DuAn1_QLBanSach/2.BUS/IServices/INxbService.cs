using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INxbService
    {
        string Add(NxbView NxbV);
        string Delete(NxbView NxbV);
        string Update(NxbView NxbV);
        List<NxbView> GetAll();
    }
}
