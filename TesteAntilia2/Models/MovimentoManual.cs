using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAntilia2.Models
{
    public class MovimentoManual : IModelBase
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public long NumeroLancamento { get; set; }
        public string CodigoProduto { get; set; }
        public string CodigoProdutoCosif { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal Valor { get; set; }
        public ProdutoCosif ProdutoCosif { get; set; }

    }
}