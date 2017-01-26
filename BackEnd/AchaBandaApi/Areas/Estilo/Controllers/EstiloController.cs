using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchaBandaApi.Areas.Estilo.Controllers
{
    public class EstiloController : ApiController
    {
        // GET: api/Estilo
        public IEnumerable<EstiloModel> Get()
        {
            var facadeEstilo = new EstiloFacade();

            var estilo = facadeEstilo.SelecionarTodos();

            return estilo;
        }

        // GET: api/Estilo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Estilo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Estilo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Estilo/5
        public void Delete(int id)
        {
        }
    }
}
