using mvcRecipeBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcRecipeBook.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeBookDataSource _db;

        public HomeController(IRecipeBookDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Recipes()
        {
            var recipes = _db.Recipes;

            return View(recipes);
        }

        public ActionResult Ingredients()
        {
            var ingredients = _db.Ingredients;

            return View(ingredients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}