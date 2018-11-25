using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IInstalacaoRespositorio
    {
        IEnumerable<Instalacao> GetAll();
        Instalacao Get(int id);
        Instalacao Add(Instalacao item);
        void Remove(int id);
        bool Update(Instalacao item);
    }
}