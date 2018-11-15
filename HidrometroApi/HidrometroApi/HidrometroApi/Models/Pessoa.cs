using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models
{
    public class Pessoa
    {
        public long IdPessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public bool PessoaAtiva { get; set; }
    }
}