using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IPerfilRepositorio
    {
        IEnumerable<Perfil> GetAll();
        Perfil Get(int id);
        Perfil Add(Perfil item);
        void Remove(int id);
        bool Update(Perfil item);
    }
}