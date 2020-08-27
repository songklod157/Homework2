using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            var game = (
                            A:"far cry 5",
                            B:"GTA 5",
                            C:"Dota 2",
                            D:"Valorant",
                            E:"Monter hunter world",
                            F:"Assassin's creed",
                            G:"Tom Clancys",
                            H:"Doom",
                            I:"Division",
                            J:"Bettlefield",
                            K:"Just cause",
                            L:"Fall guys",
                            M:"Watch dogs2",
                            N:"Over wacth",
                            O:"Devil maycry5");
            ViewBag.one = game.A;
            ViewBag.one = game.B;
            ViewBag.one = game.C;
            ViewBag.one = game.D;
            ViewBag.one = game.E;
            ViewBag.one = game.F;
            ViewBag.one = game.G;
            ViewBag.one = game.H;
            ViewBag.one = game.I;
            ViewBag.one = game.J;
            ViewBag.one = game.K;
            ViewBag.one = game.L;
            ViewBag.one = game.M;
            ViewBag.one = game.N;
            ViewBag.one = game.O;
            return View();
        }

        [HttpPost]

        public IActionResult Add()
        {
            int n3 = Convert.ToInt32(HttpContext.Request.Form["txt3"].ToString());
            int n4 = Convert.ToInt32(HttpContext.Request.Form["txt4"].ToString());
            int result2 = n3 + n4;
            ViewBag.plus = result2.ToString();
            return View("Index");
        }
        public IActionResult Getname()
        {
            var name = HttpContext.Request.Form["name"].ToString();
            ViewBag.customer = name;
            return View("Index");
        }
        public IActionResult Getorder()
        {
            var first = HttpContext.Request.Form["txt6"].ToString();
            var last = HttpContext.Request.Form["txt7"].ToString();
            ViewBag.name = first + last;
            return View("Index");
        }
    }
}
