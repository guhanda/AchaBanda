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
            IEnumerable<EstiloModel> estilo;

            using (var facadeEstilo = new EstiloFacade())
            {
                 estilo = facadeEstilo.SelecionarTodos();
            }

            return estilo;
        }

        // GET: api/Estilo/5
        public EstiloModel Get(int id)
        {
            EstiloModel estilo;

            using (var facadeEstilo = new EstiloFacade())
            {
                estilo = facadeEstilo.Selecionar(id);
            }

            return estilo;
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
