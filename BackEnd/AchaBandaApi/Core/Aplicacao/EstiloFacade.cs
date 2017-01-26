using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using Dapper;
using System.Collections.Generic;



namespace AchaBandaApi.Core.Aplicacao
{
    public class EstiloFacade : FacadeCRUD<EstiloModel>
    {
        public IEnumerable<EstiloModel> SelecionarTodos()
        {
            var retorno = connection.GetList<EstiloModel>("order by indavaliacao desc, nmestilo asc");

            return retorno;
        }
    }
}