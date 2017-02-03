using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AchaBandaApi.Areas.UsuarioEstilo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuarioEstiloController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public UsuarioEstiloModel Get(int id)
        {
            UsuarioEstiloModel usuario;

            using (var facade = new UsuarioEstiloFacade())
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
        public long Put([FromBody]UsuarioEstiloModel usuarioEstilo)
        {
            long retorno = 0;

            var facade = new UsuarioEstiloFacade();
            var inserir = facade.Inserir(usuarioEstilo);
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