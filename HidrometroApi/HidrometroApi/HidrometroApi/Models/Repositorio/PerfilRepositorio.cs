using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        private List<Perfil> listaPerfil = new List<Perfil>();
        private int _nextId = 1;

        public PerfilRepositorio()
        {
            //Add(new Perfil { CPF_CNPJ = "123.456.789.00", DataNascimento = new DateTime(2018, 04, 25), Email = "Perfil1@listaPerfil.com", IdPerfil = 1, Nome = "Perfil 1", PerfilAtiva = true, Senha = "Perfil1" });
        }

        public Perfil Add(Perfil item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdPerfil = _nextId++;
            listaPerfil.Add(item);
            return item;
        }

        public Perfil Get(int id)
        {
            return listaPerfil.Find(p => p.IdPerfil == id);
        }

        public IEnumerable<Perfil> GetAll()
        {
            return listaPerfil;
        }

        public void Remove(int id)
        {
            listaPerfil.RemoveAll(p => p.IdPerfil == id);
        }

        public bool Update(Perfil item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = listaPerfil.FindIndex(p => p.IdPerfil == item.IdPerfil);

            if (index == -1)
            {
                return false;
            }
            listaPerfil.RemoveAt(index);
            listaPerfil.Add(item);
            return true;
        }
    }
}