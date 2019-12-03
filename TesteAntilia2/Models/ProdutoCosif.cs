using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAntilia2.Models
{
    public class ProdutoCosif : IModelBase
    {
        public string CodigoProduto { get; set; }
        public Produto ProdutoRelacionado { get; set; }
        public string Codigo { get; set; }
        public string CodigoClassificacao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<MovimentoManual> MovimentosManuais { get; set; }
    }
}