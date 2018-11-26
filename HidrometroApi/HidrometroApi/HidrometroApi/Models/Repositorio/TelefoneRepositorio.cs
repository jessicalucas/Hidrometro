using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HidrometroApi.Models.Repositorio
{
    public class TelefoneRepositorio : ITelefoneRepositorio
    {
        private List<Telefone> listaTelefone = new List<Telefone>();
        private int _nextId = 1;

        public TelefoneRepositorio()
        {
            //Add(new Telefone { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "Telefone1@listaTelefone.com", IdTelefone = 1, Nome = "Telefone 1", TelefoneAtiva = true, Senha = "Telefone1" });
        }

        public Telefone Add(Telefone item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdTelefone = _nextId++;
            listaTelefone.Add(item);
            return item;
        }

        public Telefone Get(int id)
        {
            return listaTelefone.Find(p => p.IdTelefone == id);
        }

        public IEnumerable<Telefone> GetAll()
        {
            return listaTelefone;
        }

        public void Remove(int id)
        {
            listaTelefone.RemoveAll(p => p.IdTelefone == id);
        }

        public bool Update(Telefone item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaTelefone.FindIndex(p => p.IdTelefone == item.IdTelefone);

            if (index == -1)
            {
                return false;
            }
            listaTelefone.RemoveAt(index);
            listaTelefone.Add(item);
            return true;
        }
    }
}