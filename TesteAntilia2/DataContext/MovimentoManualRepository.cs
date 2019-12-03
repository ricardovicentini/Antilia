using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TesteAntilia2.DBContext;
using TesteAntilia2.Models;

namespace TesteAntilia2.DataContext
{
    public class MovimentoManualRepository : ICrud<MovimentoManual>
    {
        AntiliaDBContext db;

        public MovimentoManualRepository(AntiliaDBContext context)
        {
            this.db = context;
        }

        public void Adicionar(MovimentoManual model)
        {
            throw new NotImplementedException();
        }

        public void Excluir(MovimentoManual model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimentoManual> Listar()
        {
            return db.MovimentosManuais.Include(m => m.ProdutoCosif);
        }

        public void Obter(object id)
        {
            throw new NotImplementedException();
        }
    }
}