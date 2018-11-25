using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private List<Pessoa> listaPessoa = new List<Pessoa>();
        private int _nextId = 1;

        public PessoaRepositorio()
        {
            Add(new Pessoa { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "pessoa1@listaPessoa.com", IdPessoa = 1, Nome = "Pessoa 1", PessoaAtiva = true, Senha = "Pessoa1" });
        }

        public PessoaRepositorio(string cpfCnpj, DateTime? dataNascimento, string email, string nome, bool pessoaAtiva, string senha)
        {
            Add(new Pessoa { CPF_CNPJ = cpfCnpj, DataNascimento = dataNascimento, Email = email, Nome = nome, PessoaAtiva = pessoaAtiva, Senha = senha });
        }

        public Pessoa Add(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdPessoa = _nextId++;
            listaPessoa.Add(item);
            return item;
        }

        public Pessoa Get(int id)
        {
            return listaPessoa.Find(p => p.IdPessoa == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return listaPessoa;
        }

        public void Remove(int id)
        {
            listaPessoa.RemoveAll(p => p.IdPessoa == id);
        }

        public bool Update(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaPessoa.FindIndex(p => p.IdPessoa == item.IdPessoa);

            if (index == -1)
            {
                return false;
            }
            listaPessoa.RemoveAt(index);
            listaPessoa.Add(item);
            return true;
        }
    }
}