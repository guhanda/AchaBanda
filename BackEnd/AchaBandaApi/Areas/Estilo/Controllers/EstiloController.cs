using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AchaBandaApi.Areas.Estilo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
