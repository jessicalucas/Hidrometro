//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HidrometroApi.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Pessoa
    {
        public Pessoa()
        {
            this.Perfil = new List<Perfil>();
        }

        public long IdPessoa { get; set; }
        public string CPF_CNPJ { get; set; }
        public long? IdEndereco { get; set; }
        public long? IdTelefone { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public bool PessoaAtiva { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Perfil> Perfil { get; set; }
        public virtual Telefone Telefone { get; set; }
    }
}
