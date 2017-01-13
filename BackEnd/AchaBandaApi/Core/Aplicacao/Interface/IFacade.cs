using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchaBandaApi.Core.Aplicacao.Interface
{
    interface IFacade<T>
    {

        T Selecionar(int id);

        T Inserir(T item);

        T Atualizar(T item);

        bool Deletar(int id);

    }
}
