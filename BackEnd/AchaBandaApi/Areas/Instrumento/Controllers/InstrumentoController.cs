using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchaBandaApi.Areas.Instrumento.Controllers
{
    public class InstrumentoController : ApiController
    {
        // GET: api/Instrumento
        public IEnumerable<InstrumentoModel> Get()
        {
            var facadeIntrumento = new InstrumentoFacade();

            var instrumento = facadeIntrumento.SelecionarTodos();

            return instrumento;
        }

        // GET: api/Instrumento/5
        public InstrumentoModel Get(int id)
        {
            var facadeIntrumento = new InstrumentoFacade();

            var instrumento = facadeIntrumento.Selecionar(1);
                
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
