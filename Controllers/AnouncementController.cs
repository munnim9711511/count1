using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class AnounceController : Controller {
        private readonly DataContext _db;
        public AnounceController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult CouncilAnounce () {
            ViewBag.council = _db.anouncementsModels.Where(x=>x.Catogary == "council").OrderBy (x => x.Id).ToArray ();
            return View (ViewBag.council);
        }

        public IActionResult OrganizationAnounce () {
            ViewBag.organization = _db.anouncementsModels.Where(x=>x.Catogary == "organization").OrderBy (x => x.Id).ToArray ();

            return View (ViewBag);
        }
        public IActionResult LocalAnounce () {
            ViewBag.publican = _db.anouncementsModels.Where(x=>x.Catogary == "public").OrderBy (x => x.Id).ToArray ();

            return View (ViewBag);
        }

    }
}