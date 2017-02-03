using AchaBandaApi.Core.Aplicacao.Interface;
using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using System;
using Dapper;
using System.Linq;


namespace AchaBandaApi.Core.Aplicacao
{
    public class UsuarioInstrumentoFacade : FacadeCRUD<UsuarioInstrumentoModel>
    {
        public bool Deletar(int id)
        {
            var retorno = connection.Delete<UsuarioInstrumentoModel>(id);

            return retorno > 0 ? true : false;
        }

        public UsuarioInstrumentoModel Inserir(UsuarioInstrumentoModel item)
        {
            UsuarioInstrumentoModel retorno;

            retorno = connection.GetList<UsuarioInstrumentoModel>("Where idUsuario = " + item.idUsuario + " and idInstrumento = " + item.idInstrumento).FirstOrDefault();

            if (retorno == null)
            {
                var identity = connection.Insert(item);
                retorno = connection.Get<UsuarioInstrumentoModel>(identity);
            }

            return retorno;
        }

        public UsuarioInstrumentoModel Selecionar(long id)
        {
            var retorno = connection.Get<UsuarioInstrumentoModel>(id);

            return retorno;
        }
    }
}