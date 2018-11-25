using HidrometroApi.Models;
using HidrometroApi.Models.Interface;
using HidrometroApi.Models.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HidrometroApi.Controllers
{
    public class PessoaController : ApiController
    {
        static readonly IPessoaRepositorio repositorio = new PessoaRepositorio();

        public IEnumerable<Pessoa> GetAll()
        {
            return repositorio.GetAll();
        }

        public Pessoa Get(int id)
        {
            Pessoa item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        //public IEnumerable<Pessoa> GetlistaPessoaPorCategoria(string categoria)
        //{
        //    return repositorio.GetAll().Where(
        //        p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        //}

        public HttpResponseMessage Post(Pessoa item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Pessoa>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.IdPessoa });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void Put(int id, Pessoa pessoa)
        {
            pessoa.IdPessoa = id;
            if (!repositorio.Update(pessoa))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void Delete(int id)
        {
            Pessoa item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }

    }
}
