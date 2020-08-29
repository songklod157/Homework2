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

            List<ListData> PureList = new List<ListData> {
                new ListData{game="Far Cry 5",price= 620},
                new ListData{game="Gta 5",price= 550},
                new ListData{game="Dota 2",price= 360},
                new ListData{game="Valorant",price= 130},
                new ListData{game="Monter Hunter World",price= 480},
                new ListData{game="Assassin's Creed",price= 510},
                new ListData{game="Tom Clancys",price= 610},
                new ListData{game="Doom",price= 220},
                new ListData{game="Division",price= 145},
                new ListData{game="Bettlefield",price= 310},
                new ListData{game="Just Cause",price= 210},
                new ListData{game="Fall Guys",price= 510},
                new ListData{game="Watch Dogs2",price= 650},
                new ListData{game="Over Wacth",price= 430},
                new ListData{game="Devil Maycry5",price= 220},
                };

            var Result = new List<ListData>();

            for (int i = 0; i < PureList.Count; i++)
            {
                Result.Add(new ListData { game = PureList[i].game, price = PureList[i].price });
            }
            return View(Result);
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
