using AchaBandaApi.Core.Aplicacao;
using AchaBandaApi.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchaBandaApi.Areas.UsuarioLocalizacao.Controllers
{
    public class UsuarioLocalizacaoController : ApiController
    {
        // POST: api/UsuarioLocalizacao
        public IEnumerable<UsuarioLocalizacaoModel> Get(int idUsuario, int km)
        {
            IEnumerable<UsuarioLocalizacaoModel> retorno;

            using (var facade = new UsuarioLocalizacaoFacade())
            {
                var usuario = facade.SelecionarUltimo(idUsuario);

                retorno = facade.SelecionarProximos(usuario, km);
            }

            return retorno;
        }

        // GET: api/UsuarioLocalizacao
        public IEnumerable<UsuarioLocalizacaoModel> Get()
        {
            IEnumerable<UsuarioLocalizacaoModel> retorno;

            using (var facade = new UsuarioLocalizacaoFacade())
            {
                retorno = facade.SelecionarTodos();
            }

            return retorno;
        }

        // GET: api/UsuarioLocalizacao/5
        public UsuarioLocalizacaoModel Get(int id)
        {
            UsuarioLocalizacaoModel retorno;

            using (var facade = new UsuarioLocalizacaoFacade())
            {
                retorno = facade.Selecionar(id);
            }

            return retorno;
        }

        // POST: api/UsuarioLocalizacao
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsuarioLocalizacao/5
        public UsuarioLocalizacaoModel Put([FromBody]UsuarioLocalizacaoModel value)
        {
            UsuarioLocalizacaoModel retorno;

            using (var facade = new UsuarioLocalizacaoFacade())
            {
                //Atualização da data de alterção
                value.DataUltimaAlteracao = DateTime.Now;

                retorno = facade.Inserir(value);
            }

            return retorno;
        }

        // DELETE: api/UsuarioLocalizacao/5
        public void Delete(int id)
        {
        }
    }
}
