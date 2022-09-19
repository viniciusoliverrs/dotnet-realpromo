using Microsoft.AspNetCore.Mvc;
using RealPromo.ApiWeb.Models;
using System.Diagnostics;

namespace RealPromo.ApiWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Promocao()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}