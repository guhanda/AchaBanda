using AchaBandaApi.Areas.Usuario.Controllers;
using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AchaBandaApi.Areas.UsuarioInstrumento.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        public HttpResponseMessage Post([FromBody]UsuarioInstrumentoModel usuarioInstrumento)
        {
            long retorno = 0;
            UsuarioInstrumentoModel inserir;

            using (var facade = new UsuarioInstrumentoFacade())
            {
                inserir = facade.Inserir(usuarioInstrumento);

                if (inserir != null)
                {
                    retorno = inserir.idUsuario;
                }
            }

            return Request.CreateResponse(HttpStatusCode.OK, new RetornoBase<UsuarioInstrumentoModel> { Success = true, Value = inserir });
        }

        // PUT: api/Usuario/5
        public UsuarioInstrumentoModel Put([FromBody]UsuarioInstrumentoModel usuarioInstrumento)
        {
            UsuarioInstrumentoModel retorno;

            using (var facade = new UsuarioInstrumentoFacade())
            {
                retorno = facade.Atualizar(usuarioInstrumento);
            }
                
            return retorno;
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}