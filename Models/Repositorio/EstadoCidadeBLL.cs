using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceMVC.Models.Repositorio
{
    public class EstadoCidadeBLL
    {
        //Retorna a tabela tbEstado em uma Lista
        public List<tbEstado> ObterEstado()
        {
            using (TestePraticoEntities _db = new TestePraticoEntities())
            {
                return _db.tbEstado.ToList();
            }
        }

        //Retorna a tabela tbCidade em uma lista conforme ao estado
        public List<string> ObterCidade(int idEstado)
        {
            using (TestePraticoEntities _db = new TestePraticoEntities())
            {
                return _db.tbCidade.Where(query => query.tbEstado_id == idEstado).Select(c => c.Cidade).ToList();
            }
        }
    }
}