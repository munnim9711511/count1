using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class GalleryController : Controller {
        private readonly DataContext _db;
        public GalleryController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult Index (string type) {
            ViewBag.Images = _db.GalleryModels.ToArray();
            return View (ViewBag);
        }

    }
}