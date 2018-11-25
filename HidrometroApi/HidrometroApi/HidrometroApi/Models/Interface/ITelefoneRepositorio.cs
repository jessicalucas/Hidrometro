using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface ITelefoneRepositorio
    {
        IEnumerable<Telefone> GetAll();
        Telefone Get(int id);
        Telefone Add(Telefone item);
        void Remove(int id);
        bool Update(Telefone item);
    }
}