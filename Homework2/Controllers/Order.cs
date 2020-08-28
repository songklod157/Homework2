using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class Order : Controller
    {
        [Route("/Order/Index", Name = "Order")]
        public IActionResult Index()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;

            var game = HttpContext.Request.Form["game"].ToString();
            int Q = Convert.ToInt32(HttpContext.Request.Form["qty"].ToString());
            int P = Convert.ToInt32(HttpContext.Request.Form["pri"].ToString());
            int sum = Q * P;
            ViewBag.qty = Q.ToString();
            ViewBag.pri = P.ToString();
            ViewBag.namegame = game;
            ViewBag.total = sum.ToString();
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Getname()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;
            return View("Login");
        }
        [HttpPost]
        public IActionResult Buy()
        {
            var game = HttpContext.Request.Form["game"].ToString();
            int Q = Convert.ToInt32(HttpContext.Request.Form["qty"].ToString());
            int P = Convert.ToInt32(HttpContext.Request.Form["pri"].ToString());
            int sum = Q * P;
            ViewBag.qty = Q.ToString();
            ViewBag.pri = P.ToString();
            ViewBag.namegame = game;
            ViewBag.total = sum.ToString();
            return View("Index");
        }
    }
}
