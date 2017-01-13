using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AchaBandaApi.Core.Infraestrutura
{
    public class FacadeCRUD<T> : Database
    {
        public T Atualizar(T item)
        {
            var retorno = connection.Update(item);

            return Selecionar(retorno);
        }

        public bool Deletar(int id)
        {
            var retorno = connection.Delete<T>(id);

            return retorno > 0 ? true : false;
        }

        public T Inserir(T item)
        {
            var retorno = connection.Insert<T>(item);

            return retorno;
        }

        public T Selecionar(int id)
        {
            var retorno = connection.Get<T>(id);

            return retorno;
        }
    }
}