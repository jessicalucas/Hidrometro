using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private List<Endereco> listaEndereco = new List<Endereco>();
        private int _nextId = 1;

        public EnderecoRepositorio()
        {
            //Add(new Endereco { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "Endereco1@listaEndereco.com", IdEndereco = 1, Nome = "Endereco 1", EnderecoAtiva = true, Senha = "Endereco1" });
        }

        public Endereco Add(Endereco item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdEndereco = _nextId++;
            listaEndereco.Add(item);
            return item;
        }

        public Endereco Get(int id)
        {
            return listaEndereco.Find(p => p.IdEndereco == id);
        }

        public IEnumerable<Endereco> GetAll()
        {
            return listaEndereco;
        }

        public void Remove(int id)
        {
            listaEndereco.RemoveAll(p => p.IdEndereco == id);
        }

        public bool Update(Endereco item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaEndereco.FindIndex(p => p.IdEndereco == item.IdEndereco);

            if (index == -1)
            {
                return false;
            }
            listaEndereco.RemoveAt(index);
            listaEndereco.Add(item);
            return true;
        }
    }
}