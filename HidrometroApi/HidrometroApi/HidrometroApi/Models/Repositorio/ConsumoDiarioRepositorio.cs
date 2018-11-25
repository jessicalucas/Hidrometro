using HidrometroApi.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidrometroApi.Models.Repositorio
{
    public class ConsumoDiarioRepositorio : IConsumoDiarioRepositorio
    {
        private List<ConsumoDiario> ListaConsumoDiario = new List<ConsumoDiario>();
        private int _nextId = 1;

        public ConsumoDiarioRepositorio(DateTime? dataConsumo, decimal? m3Consumidos, Perfil perfil)
        {
            Add(new ConsumoDiario { DataConsumo = dataConsumo, IdPerfil = perfil.IdPerfil, M3Consumidos = m3Consumidos, Perfil = perfil, IdConsumoDiario = _nextId });

        }

        public ConsumoDiario Add(ConsumoDiario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.IdConsumoDiario = _nextId++;
            ListaConsumoDiario.Add(item);
            return item;
        }

        public ConsumoDiario Get(int id)
        {
            return ListaConsumoDiario.Find(p => p.IdConsumoDiario == id);
        }

        public IEnumerable<ConsumoDiario> GetAll()
        {
            return ListaConsumoDiario;
        }

        public void Remove(int id)
        {
            ListaConsumoDiario.RemoveAll(p => p.IdConsumoDiario == id);
        }

        public bool Update(ConsumoDiario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = ListaConsumoDiario.FindIndex(p => p.IdConsumoDiario == item.IdConsumoDiario);

            if (index == -1)
            {
                return false;
            }
            ListaConsumoDiario.RemoveAt(index);
            ListaConsumoDiario.Add(item);
            return true;
        }
    }
}