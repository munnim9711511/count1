using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class DownloadController : Controller {
        private DataContext _db;

        public DownloadController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult Index () {

            return View ();
        }

        [HttpGet]
        public IActionResult Form () {
            ViewBag.Form = _db.LinkModels.Where (x => x.Catogary == "forms").ToArray ();
            return View (ViewBag);
        }
        public IActionResult Law () {
            return View ();
        }
        public IActionResult Ausule () {
            return View ();
        }
        public IActionResult Report () {
            return View ();
        }
        public IActionResult Documents () {
            return View ();
        }

    }
}