using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private int _nextId = 1;

        public PessoaRepositorio()
        {
            AddPessoa(new Pessoa { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "pessoa1@pessoas.com", IdPessoa = 1, Nome = "Pessoa 1", PessoaAtiva = true, Senha = "Pessoa1" });
        }

        public Pessoa AddPessoa(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdPessoa = _nextId++;
            pessoas.Add(item);
            return item;
        }

        public Pessoa GetPessoa(int id)
        {
            return pessoas.Find(p => p.IdPessoa == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return pessoas;
        }

        public void RemovePessoa(int id)
        {
            pessoas.RemoveAll(p => p.IdPessoa == id);
        }

        public bool UpdatePessoa(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = pessoas.FindIndex(p => p.IdPessoa == item.IdPessoa);

            if (index == -1)
            {
                return false;
            }
            pessoas.RemoveAt(index);
            pessoas.Add(item);
            return true;
        }
    }
}