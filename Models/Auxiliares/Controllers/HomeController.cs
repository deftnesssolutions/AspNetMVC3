using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServiceMVC.Models.Auxiliares.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Bem-vido ao exemplo prático com ASP.NET MVC";
            return View();
        }

    }
}
