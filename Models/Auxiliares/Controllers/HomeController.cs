using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceMVC.Models.Repositorio;

namespace WebServiceMVC.Models.Auxiliares.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //variáveis de acesso ao repositório
        private PessoaBLL _bllPessoa;

        public HomeController()
        {
            _bllPessoa = new PessoaBLL();
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Bem-vido ao exemplo prático ASP.NET MVC";
            // conecta a data base
            TestePraticoEntities db = new TestePraticoEntities();
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPessoa(FormCollection collection)
        {
            var cadastrado = _bllPessoa.CadastrarPessoa(collection);
            return Json(cadastrado ? new { Mensagem = "Cadastro realizado com sucesso!" } : new { Mensagem = "Houve um problema ao realizar o cadastro!" });
        }
    }
}
