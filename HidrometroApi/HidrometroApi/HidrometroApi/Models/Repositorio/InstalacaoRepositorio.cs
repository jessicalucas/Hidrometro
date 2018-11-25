using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class InstalacaoRepositorio : IInstalacaoRespositorio
    {
        private List<Instalacao> listaInstalacao = new List<Instalacao>();
        private int _nextId = 1;

        public InstalacaoRepositorio()
        {
            //Add(new Instalacao { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "Instalacao1@listaInstalacao.com", IdInstalacao = 1, Nome = "Instalacao 1", InstalacaoAtiva = true, Senha = "Instalacao1" });
        }

        public Instalacao Add(Instalacao item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdInstalacao = _nextId++;
            listaInstalacao.Add(item);
            return item;
        }

        public Instalacao Get(int id)
        {
            return listaInstalacao.Find(p => p.IdInstalacao == id);
        }

        public IEnumerable<Instalacao> GetAll()
        {
            return listaInstalacao;
        }

        public void Remove(int id)
        {
            listaInstalacao.RemoveAll(p => p.IdInstalacao == id);
        }

        public bool Update(Instalacao item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaInstalacao.FindIndex(p => p.IdInstalacao == item.IdInstalacao);

            if (index == -1)
            {
                return false;
            }
            listaInstalacao.RemoveAt(index);
            listaInstalacao.Add(item);
            return true;
        }
    }
}