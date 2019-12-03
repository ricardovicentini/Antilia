using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAntilia2.Models
{
    public class MovimentoView : IModelBase
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public long NrLancamento { get; set; }
        public decimal Valor { get; set; }


    }
}