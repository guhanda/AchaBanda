using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AchaBandaApi.Areas.UsuarioInstrumento.Controllers
{
    public class UsuarioInstrumentoController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public UsuarioInstrumentoModel Get(int id)
        {
            UsuarioInstrumentoModel usuario;

            using (var facade = new UsuarioInstrumentoFacade())
            {
                usuario = facade.Selecionar(id);
            }

            return usuario;
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public long Put([FromBody]UsuarioInstrumentoModel usuarioInstrumento)
        {
            long retorno = 0;

            var facade = new UsuarioInstrumentoFacade();
            var inserir = facade.Inserir(usuarioInstrumento);
            if (inserir != null)
            {
                retorno = inserir.idUsuario;
            }

            return retorno;
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}