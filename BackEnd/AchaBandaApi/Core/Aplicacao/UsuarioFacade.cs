using AchaBandaApi.Core.Aplicacao.Interface;
using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using System;
using Dapper;
using System.Linq;

namespace AchaBandaApi.Core.Aplicacao
{
    public class UsuarioFacade : FacadeCRUD<UsuarioModel>
    {
        public UsuarioModel Atualizar(UsuarioModel item)
        {
            var retorno = connection.Update(item);

            return Selecionar(retorno);
        }

        public bool Deletar(int id)
        {
            var retorno = connection.Delete<UsuarioModel>(id);

            return retorno > 0 ? true : false;
        }

        public UsuarioModel Inserir(UsuarioModel item)
        {
            UsuarioModel retorno;

            retorno = connection.GetList<UsuarioModel>("Where email = '"+item.Email+"'").FirstOrDefault();
            
            if (retorno == null)
            {
                retorno = connection.Insert<UsuarioModel>(item);
            }

            return retorno;
        }

        public UsuarioModel Selecionar(long id)
        {
            var retorno = connection.Get<UsuarioModel>(id);

            return retorno;
        }
    }
}