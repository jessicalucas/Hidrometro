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
    public class PessoasController : ApiController
    {
        static readonly IPessoaRepositorio repositorio = new PessoaRepositorio();

        public IEnumerable<Pessoa> GetAllPessoas()
        {
            return repositorio.GetAll();
        }

        public Pessoa GetPessoa(int id)
        {
            Pessoa item = repositorio.GetPessoa(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        //public IEnumerable<Pessoa> GetPessoasPorCategoria(string categoria)
        //{
        //    return repositorio.GetAll().Where(
        //        p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        //}

        public HttpResponseMessage PostPessoa(Pessoa item)
        {
            item = repositorio.AddPessoa(item);
            var response = Request.CreateResponse<Pessoa>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.IdPessoa });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutPessoa(int id, Pessoa pessoa)
        {
            pessoa.IdPessoa = id;
            if (!repositorio.UpdatePessoa(pessoa))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeletePessoa(int id)
        {
            Pessoa item = repositorio.GetPessoa(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.RemovePessoa(id);
        }

    }
}
