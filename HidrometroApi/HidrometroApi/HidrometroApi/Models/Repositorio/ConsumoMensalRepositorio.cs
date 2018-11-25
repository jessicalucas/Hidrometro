using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class ConsumoMensalRepositorio : IConsumoMensalRepositorio
    {
        private List<ConsumoMensal> listaConsumoMensal = new List<ConsumoMensal>();
        private int _nextId = 1;

        public ConsumoMensalRepositorio()
        {
            //Add(new ConsumoMensal { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "ConsumoMensal1@listaConsumoMensal.com", IdConsumoMensal = 1, Nome = "ConsumoMensal 1", ConsumoMensalAtiva = true, Senha = "ConsumoMensal1" });
        }

        public ConsumoMensal Add(ConsumoMensal item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdConsumoMensal = _nextId++;
            listaConsumoMensal.Add(item);
            return item;
        }

        public ConsumoMensal Get(int id)
        {
            return listaConsumoMensal.Find(p => p.IdConsumoMensal == id);
        }

        public IEnumerable<ConsumoMensal> GetAll()
        {
            return listaConsumoMensal;
        }

        public void Remove(int id)
        {
            listaConsumoMensal.RemoveAll(p => p.IdConsumoMensal == id);
        }

        public bool Update(ConsumoMensal item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaConsumoMensal.FindIndex(p => p.IdConsumoMensal == item.IdConsumoMensal);

            if (index == -1)
            {
                return false;
            }
            listaConsumoMensal.RemoveAt(index);
            listaConsumoMensal.Add(item);
            return true;
        }
    }
}