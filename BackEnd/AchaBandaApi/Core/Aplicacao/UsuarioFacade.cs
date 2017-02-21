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
                var identity = connection.Insert(item);
                retorno = connection.Get<UsuarioModel>(identity);
            }

            return retorno;
        }

        public UsuarioModel Selecionar(long id)
        {
            var retorno = connection.Get<UsuarioModel>(id);

            return retorno;
        }

        public UsuarioModel SelecionarComFiltro(UsuarioModel model) {

            var selectSql = @"SELECT * FROM Usuario WHERE (@email IS NULL OR email = @email)";

            return connection.Query<UsuarioModel>(selectSql, new
            {
                model.Email
            }).FirstOrDefault();
            

        }
    }
}