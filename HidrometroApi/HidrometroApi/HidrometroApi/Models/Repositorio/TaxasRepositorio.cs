using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class TaxasRepositorio : ITaxasRepositorio
    {
        private List<Taxas> listaTaxas = new List<Taxas>();
        private int _nextId = 1;

        public TaxasRepositorio()
        {
            //Add(new Taxas { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "Taxas1@listaTaxas.com", IdTaxa = 1, Nome = "Taxas 1", TaxasAtiva = true, Senha = "Taxas1" });
        }

        public Taxas Add(Taxas item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdTaxa = _nextId++;
            listaTaxas.Add(item);
            return item;
        }

        public Taxas Get(int id)
        {
            return listaTaxas.Find(p => p.IdTaxa == id);
        }

        public IEnumerable<Taxas> GetAll()
        {
            return listaTaxas;
        }

        public void Remove(int id)
        {
            listaTaxas.RemoveAll(p => p.IdTaxa == id);
        }

        public bool Update(Taxas item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaTaxas.FindIndex(p => p.IdTaxa == item.IdTaxa);

            if (index == -1)
            {
                return false;
            }
            listaTaxas.RemoveAt(index);
            listaTaxas.Add(item);
            return true;
        }
    }
}