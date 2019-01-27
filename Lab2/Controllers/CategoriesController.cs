using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        // GET: Categories
        public ActionResult Details(string category)
        {
            ViewBag.message = category+ "You selected category: " + category;
            return View();
        }
    }
}