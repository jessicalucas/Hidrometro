using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Interface
{
    public interface IConsumoDiarioRepositorio
    {
        IEnumerable<ConsumoDiario> GetAll();
        ConsumoDiario Get(int id);
        ConsumoDiario Add(ConsumoDiario item);
        void Remove(int id);
        bool Update(ConsumoDiario item);
    }
}