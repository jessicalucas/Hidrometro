using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IConsumoMensalRepositorio
    {
        IEnumerable<ConsumoMensal> GetAll();
        ConsumoMensal Get(int id);
        ConsumoMensal Add(ConsumoMensal item);
        void Remove(int id);
        bool Update(ConsumoMensal item);
    }
}