using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using System.Collections.Generic;
using Dapper;

namespace AchaBandaApi.Core.Aplicacao
{
    public class InstrumentoFacade : FacadeCRUD<InstrumentoModel>
    {
        public IEnumerable<InstrumentoModel> SelecionarTodos()
        {
            var retorno = connection.GetList<InstrumentoModel>("order by indavaliacao desc, nminstrumento asc");

            return retorno;
        }
    }
}