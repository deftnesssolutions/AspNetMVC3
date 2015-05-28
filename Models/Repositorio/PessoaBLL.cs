using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServiceMVC.Models.Repositorio
{
    public class PessoaBLL
    {
        private TestePraticoEntities _db;

        public PessoaBLL()
        {
            _db = new TestePraticoEntities();
        }

        public bool CadastrarPessoa(FormCollection collection)
        {
            try
            {
                var objPessoa = new tbPessoa();

                objPessoa.nome = collection["nome"].Trim().ToUpper();
                objPessoa.cpf = collection["cpf"].Trim().Replace("-", "");
                objPessoa.telefone = collection["telefone"].Trim().Replace("-", "").Replace("(", "").Replace(")", "");
                objPessoa.email = collection["email"];
                objPessoa.rg = collection["rg"];
                objPessoa.genero = collection["genero"];
                objPessoa.dataNasc = Convert.ToDateTime(collection["dataNasc"]);

                _db.AddTotbPessoa(objPessoa);
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