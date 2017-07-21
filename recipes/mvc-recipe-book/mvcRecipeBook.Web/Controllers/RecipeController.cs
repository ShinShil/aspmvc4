using mvcRecipeBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcRecipeBook.Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeBookDataSource _db;

        public RecipeController(IRecipeBookDataSource db)
        {
            _db = db;
        }

        // GET: Recipe
        public ActionResult Index()
        {
            var recipes = _db.Recipes;

            return View(recipes);
        }

        // GET: Recipe/Details/5
        public ActionResult Details(int id)
        {
            var recipe = _db.Recipes.Single(r => r.Id == id);

            return View(recipe);
        }

        // GET: Recipe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipe/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipe/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
