using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class ParametroSistemaRepositorio : IParametroSistemaRepositorio
    {
        private List<ParametroSistema> listaParametroSistema = new List<ParametroSistema>();
        private int _nextId = 1;

        public ParametroSistemaRepositorio()
        {
            //Add(new ParametroSistema { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "ParametroSistema1@listaParametroSistema.com", IdParametro = 1, Nome = "ParametroSistema 1", ParametroSistemaAtiva = true, Senha = "ParametroSistema1" });
        }

        public ParametroSistema Add(ParametroSistema item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdParametro = _nextId++;
            listaParametroSistema.Add(item);
            return item;
        }

        public ParametroSistema Get(int id)
        {
            return listaParametroSistema.Find(p => p.IdParametro == id);
        }

        public IEnumerable<ParametroSistema> GetAll()
        {
            return listaParametroSistema;
        }

        public void Remove(int id)
        {
            listaParametroSistema.RemoveAll(p => p.IdParametro == id);
        }

        public bool Update(ParametroSistema item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaParametroSistema.FindIndex(p => p.IdParametro == item.IdParametro);

            if (index == -1)
            {
                return false;
            }
            listaParametroSistema.RemoveAt(index);
            listaParametroSistema.Add(item);
            return true;
        }
    }
}