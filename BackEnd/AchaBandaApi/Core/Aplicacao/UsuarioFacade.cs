﻿using AchaBandaApi.Core.Aplicacao.Interface;
using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using System;
using Dapper;
using System.Linq;

namespace AchaBandaApi.Core.Aplicacao
{
    public class UsuarioFacade : Database, IFacade<UsuarioModel>
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
            var retorno = connection.Insert<UsuarioModel>(item);

            return retorno;
        }

        public UsuarioModel Selecionar(int id)
        {
            var retorno = connection.Get<UsuarioModel>(id);

            return retorno;
        }
    }
}