using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchaBandaApi.Areas.Usuario.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public UsuarioModel Get(int id)
        {
            UsuarioModel usuario;

            using (var facade = new UsuarioFacade())
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
        public long Put([FromBody]UsuarioModel usuario)
        {
            long retorno = 0;

            var facade = new UsuarioFacade();
            var inserir = facade.Inserir(usuario);
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
