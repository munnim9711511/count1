using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Coun.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class NewsController : Controller {
        private readonly DataContext _db;
        public NewsController (DataContext _db) {
            this._db = _db;
        }
        public IActionResult Index (int id) {
           ViewBag.news = _db.NewsModels.Where(x=>x.Id == id).ToArray();
            return View (ViewBag);
        }
        [HttpGet]
       


        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}