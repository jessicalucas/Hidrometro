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

    public partial class ConsumoMensal
    {
        public ConsumoMensal()
        {
            this.ConsumoDiario = new List<ConsumoDiario>();
        }
        public long IdConsumoMensal { get; set; }
        public long? IdConsumoDiario { get; set; }
        public decimal? TotalConsumido { get; set; }
        public decimal? Premiacao { get; set; }
        public decimal? Advertencia { get; set; }
        public DateTime? MesAno { get; set; }

        public virtual ICollection<ConsumoDiario> ConsumoDiario { get; set; }
    }
}
