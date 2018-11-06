using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class LinkController : Controller {
        private readonly DataContext _db;
        public LinkController (DataContext _db) {
            this._db = _db;
        }

        public IActionResult Info (string id) {
            ViewBag.Info = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult History () {
            ViewBag.history = _db.LinkModels.Where (x => x.Catogary == "history").ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult GuestHouse () {
            ViewBag.GH = _db.LinkModels.Where (x => x.Catogary == "GH").ToArray ();
            return View (ViewBag);
        }
        [HttpGet]
        public IActionResult Bussiness () {
            ViewBag.bussines = _db.LinkModels.Where (x => x.Catogary == "bussiness").ToArray ();
            return View (ViewBag);
        }

    }
}