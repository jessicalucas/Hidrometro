using HidrometroApi.Models;
using HidrometroApi.Models.Interface;
using HidrometroApi.Models.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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

        public async Task<Pessoa> GetAsync(int id)
        {
            Pessoa item = await Task.FromResult(repositorio.Get(id));
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


    public class TelefoneController : ApiController
    {

        private readonly HIDROVIVAEntities _repositorio;
        public TelefoneController(HIDROVIVAEntities repositorio)
        {
            _repositorio = repositorio;
        }
        //static readonly ITelefoneRepositorio repositorio = new TelefoneRepositorio();

        [HttpGet]
        public IEnumerable<Telefone> GetAll()
        {
            return _repositorio.Telefone;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get([FromBody]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Telefone item = await _repositorio.Telefone.FindAsync(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Ok(item);
        }

        //[HttpGet]
        //public async Task<Telefone> GetAsync(int id)
        //{
        //    Telefone item = await Task.FromResult(_repositorio.Telefone.FindAsync(id));
        //    if (item == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return item;
        //}

        //[HttpPost]
        //public HttpResponseMessage Post(Telefone item)
        //{
        //    item = repositorio.Add(item);
        //    var response = Request.CreateResponse<Telefone>(HttpStatusCode.Created, item);


        //    string uri = Url.Link("DefaultApi", new { id = item.IdTelefone });
        //    response.Headers.Location = new Uri(uri);
        //    return response;
        //}

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] Telefone telefone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repositorio.Telefone.Add(telefone);
            await _repositorio.SaveChangesAsync();
            return CreatedAtRoute("GetCliente", new { id = telefone.IdTelefone }, telefone);
        }

        //[HttpPut]
        //public void Put(int id, Telefone telefone)
        //{
        //    telefone.IdTelefone = id;
        //    if (!repositorio.Update(telefone))
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //}

        //[HttpDelete]
        //public void Delete(int id)
        //{
        //    Telefone item = repositorio.Get(id);

        //    if (item == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    repositorio.Remove(id);
        //}

    }
}
