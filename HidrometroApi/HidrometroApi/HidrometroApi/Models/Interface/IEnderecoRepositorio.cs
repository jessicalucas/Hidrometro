using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IEnderecoRepositorio
    {
        IEnumerable<Endereco> GetAll();
        Endereco Get(int id);
        Endereco Add(Endereco item);
        void Remove(int id);
        bool Update(Endereco item);
    }
}