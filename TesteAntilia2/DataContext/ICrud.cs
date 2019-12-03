using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAntilia2.Models;

namespace TesteAntilia2.DataContext
{
    interface ICrud<T> where T : IModelBase
    {
        IEnumerable<T> Listar();
        void Adicionar(T model);
        void Excluir(T model);
        void Obter(object id);
    }
}
