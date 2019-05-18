using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace AutoCarWeb.Controllers
{
    public class HomeController : Controller
    {
        private IDatabase _database;
        public HomeController()
        {
            _database = LiteDBDatabase.GetInstance();
        }
        public ActionResult Index()
        {
            //ViewData["Autos"] = "Hola";
            //ViewBag.Autos = database.GetAutos();
            var autos = _database.GetAutos();
            return View(autos);
        }
        [HttpGet]
        public ActionResult Read(int id)
        {
            var auto = _database.GetAutos().FirstOrDefault(x => x._id == id);
            return View(auto);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var auto = _database.GetAutos().FirstOrDefault(x => x._id == id);
            return View(auto);
        }
        [HttpPost]
        public ActionResult Edit(Auto auto)
        {
            if (auto._id != 0)
                _database.UpdateAuto(auto);
            else
                _database.InsertAuto(auto);
            return View(auto);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var auto = new Auto();
            return View("Edit", auto);
        }
    }
}