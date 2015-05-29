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
        private ProdutoBLL _bllProduto;
        private EstadoCidadeBLL _bllEstadoCidade;
        public HomeController()
        {
            _bllPessoa = new PessoaBLL();
            _bllProduto = new ProdutoBLL();
            _bllEstadoCidade = new EstadoCidadeBLL();
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Bem-vido ao exemplo prático ASP.NET MVC";
            // conecta a data base
            TestePraticoEntities db = new TestePraticoEntities();
            // Recuperar estados e construi a SelectList.
            ViewBag.Estado = new SelectList(db.tbEstado, "Id", "Estado");

            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPessoa(FormCollection collection)
        {
            var cadastrado = _bllPessoa.CadastrarPessoa(collection);
            return Json(cadastrado ? new { Mensagem = "Cadastro realizado com sucesso!" } : new { Mensagem = "Houve um problema ao realizar o cadastro!" });
        }

        [HttpPost]
        public ActionResult CadastrarProduto(FormCollection collection)
        {
            var cadastrado = _bllProduto.CadastrarProduto(collection);
            return Json(cadastrado ? new { Mensagem = "Cadastro realizado com sucesso!" } : new { Mensagem = "Houve um problema ao realizar o cadastro!" });
        }

        [HttpPost]
        public ActionResult getEstadoByCidade(string selectedValue)
        {
            EstadoCidadeBLL EstadoCidade = new EstadoCidadeBLL();
            List<string> estadoList = new List<string>();
            estadoList = EstadoCidade.ObterCidade(Convert.ToInt32(selectedValue));
            return Json(new { EstadoList = estadoList });
        }
    }
}
