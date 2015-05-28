using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServiceMVC.Models.Repositorio
{
    public class ProdutoBLL
    {
        private TestePraticoEntities _db;

        public ProdutoBLL()
        {
            _db = new TestePraticoEntities();
        }

        public bool CadastrarProduto(FormCollection collection)
        {
            try
            {
                var objProduto = new tbProduto();

                objProduto.Produto = collection["nome"].Trim().ToUpper();
                objProduto.Fabricacao = Convert.ToDateTime(collection["fabricacao"]);
                objProduto.Validade = Convert.ToDateTime(collection["validade"]);
                _db.AddTotbProduto(objProduto);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}