using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IParametroSistemaRepositorio
    {
        IEnumerable<ParametroSistema> GetAll();
        ParametroSistema Get(int id);
        ParametroSistema Add(ParametroSistema item);
        void Remove(int id);
        bool Update(ParametroSistema item);
    }
}