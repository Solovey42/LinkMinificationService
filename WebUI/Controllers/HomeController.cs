using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        LinksContext db;

        public HomeController(ILogger<HomeController> logger, LinksContext context)
        {
            _logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var links = db.Links.ToList();
            return View(new IndexViewModel(links));
        }
        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                db.Links.Add(new Link { LongAddress = model.LongAddress, ShortAddress = "asd" });
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            var links = db.Links.ToList();
            model.Links = links;
            return View(model);
        }

        public IActionResult Privacy()
        {
            var itemsToDelete = db.Set<Link>();
            db.Links.RemoveRange(itemsToDelete);
            db.SaveChanges();
            return View();
        }
    }
}
