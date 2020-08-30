using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework2.Models;

namespace Homework2.Controllers
{
    public class Order : Controller
    {
        [Route("/Order/Index", Name = "Order")]
        public IActionResult Index()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;

            var listgame = new List<ListData>();
            listgame.Add(new ListData { game = "Far Cry 5", price = 620 });
            listgame.Add(new ListData { game="Gta 5",price= 550});
            listgame.Add(new ListData { game="Dota 2",price= 360});
            listgame.Add(new ListData { game="Valorant",price= 130});
            listgame.Add(new ListData { game="Monter Hunter World",price= 480});
            listgame.Add(new ListData { game="Assassin's Creed",price= 510});
            listgame.Add(new ListData { game="Tom Clancys",price= 610});
            listgame.Add(new ListData { game="Doom",price= 220});
            listgame.Add(new ListData { game="Division",price= 145});
            listgame.Add(new ListData { game="Bettlefield",price= 310});
            listgame.Add(new ListData { game="Just Cause",price= 210});
            listgame.Add(new ListData { game="Fall Guys",price= 510});
            listgame.Add(new ListData { game="Watch Dogs2",price= 650});
            listgame.Add(new ListData { game="Over Wacth",price= 430});
            listgame.Add(new ListData { game="Devil Maycry5",price= 220});

            return View(listgame);
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult order()
        {
            return View();
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
            return View("order");
        }
        public IActionResult Getname()
        {
            var fullname = HttpContext.Request.Form["name"].ToString();
            ViewBag.name = fullname;
            return View("Login", "Index");
        }
    }
}
