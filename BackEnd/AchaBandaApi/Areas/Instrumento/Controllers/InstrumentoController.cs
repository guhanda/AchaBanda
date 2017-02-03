using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AchaBandaApi.Areas.Instrumento.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InstrumentoController : ApiController
    {
        // GET: api/Instrumento
        public IEnumerable<InstrumentoModel> Get()
        {
            IEnumerable<InstrumentoModel> instrumento;

            using (var facadeIntrumento = new InstrumentoFacade())
            {
                instrumento = facadeIntrumento.SelecionarTodos();
            }

            return instrumento;
        }

        // GET: api/Instrumento/5
        public InstrumentoModel Get(int id)
        {
            InstrumentoModel instrumento;

            using (var facadeIntrumento = new InstrumentoFacade())
            {
                instrumento = facadeIntrumento.Selecionar(1);
            }
              
            return instrumento;
        }

        // POST: api/Instrumento
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Instrumento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Instrumento/5
        public void Delete(int id)
        {
        }
    }
}
