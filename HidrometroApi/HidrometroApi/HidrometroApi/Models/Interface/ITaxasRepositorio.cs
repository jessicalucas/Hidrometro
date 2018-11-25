using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface ITaxasRepositorio
    {
        IEnumerable<Taxas> GetAll();
        Taxas Get(int id);
        Taxas Add(Taxas item);
        void Remove(int id);
        bool Update(Taxas item);
    }
}