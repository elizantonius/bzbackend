using AppDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Interfaces
{
    public interface IWartaMinggu
    {
        ICollection<WartaJemaat> GetWartas();
        Task<WartaJemaat> GetById(int Libid);
        Task<WartaJemaat> Post(WartaJemaat liturgiIbadah);
        Task<WartaJemaat> Put(WartaJemaat liturgiIbadah);
        Task<bool> Delete(int Libid);
    }
}
