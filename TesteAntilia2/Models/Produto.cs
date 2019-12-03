using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAntilia2.Models
{
    public class Produto : IModelBase
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProdutoCosif> CosifsRelacionados { get; set; }
    }
}