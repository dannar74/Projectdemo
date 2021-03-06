﻿using Projectdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projectdemo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarTodos()
        {
            var videojuegos = db.Videojuegos.ToList();
            return PartialView("_MostrarTodos", videojuegos);
        }

        public ActionResult MostrarVideojuego(int id)
        {
            Videojuego videojuego = db.Videojuegos.Find(id);
            if (videojuego == null)
            {
                return HttpNotFound();
            }
            return PartialView("_MostrarVideojuego", videojuego);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}