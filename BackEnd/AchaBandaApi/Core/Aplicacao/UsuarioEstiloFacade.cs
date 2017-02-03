using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Aplicacao
{
    public class UsuarioEstiloFacade : FacadeCRUD<UsuarioEstiloModel>
    {
        public bool Deletar(int id)
        {
            var retorno = connection.Delete<UsuarioEstiloModel>(id);

            return retorno > 0 ? true : false;
        }

        public UsuarioEstiloModel Inserir(UsuarioEstiloModel item)
        {
            UsuarioEstiloModel retorno;

            retorno = connection.GetList<UsuarioEstiloModel>("Where idUsuario = " + item.idUsuario + " and idEstilo = " + item.idEstilo).FirstOrDefault();

            if (retorno == null)
            {
                var identity = connection.Insert(item);
                retorno = connection.Get<UsuarioEstiloModel>(identity);
            }

            return retorno;
        }

        public UsuarioEstiloModel Selecionar(long id)
        {
            var retorno = connection.Get<UsuarioEstiloModel>(id);

            return retorno;
        }
    }
}