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

    public partial class Telefone
    {
        public Telefone()
        {
            this.Pessoa = new List<Pessoa>();
        }

        public long IdTelefone { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }

        public virtual ICollection<Pessoa> Pessoa { get; set; }
    }
}
