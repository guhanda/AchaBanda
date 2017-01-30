using Dapper;
using MiniProfiler.Integrations;
using System;
using System.Collections.Generic;
using System.IO;
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
            var retorno = connection.Insert(item);

            T model;

            if(retorno > 0 )
            {
                model = connection.Get<T>(retorno);
            }
            else
            {
                model = default(T);
            }

            return model;
        }

        public T Selecionar(int id)
        {
            var retorno = connection.Get<T>(id);

            return retorno;
        }

        public IEnumerable<T> SelecionarTodos()
        {
            var retorno = connection.GetList<T>();

            return retorno;
        }
    }
}