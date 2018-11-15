using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IPessoaRepositorio
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa GetPessoa(int id);
        Pessoa AddPessoa(Pessoa item);
        void RemovePessoa(int id);
        bool UpdatePessoa(Pessoa item);
    }
}