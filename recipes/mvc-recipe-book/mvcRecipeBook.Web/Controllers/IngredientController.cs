using mvcRecipeBook.Domain;
using mvcRecipeBook.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcRecipeBook.Web.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IRecipeBookDataSource _db;

        public IngredientController(IRecipeBookDataSource db)
        {
            _db = db;
        }

        // GET: Ingredient
        public ActionResult Index()
        {
            var ingredients = _db.Ingredients;

            return View(ingredients);
        }

        public ActionResult Create(int recipeId)
        {
            var recipe = _db.Recipes.Single(r => r.Id == recipeId);
            var recipeName = recipe.Name;
            var model = new CreateIngredientViewModel()
            {
                Amount = 1,
                Name = "",
                RecipeId = recipeId,
                RecipeName = recipeName
            };

            return View(model);
        }

        // POST: Ingredient/Create
        [HttpPost]
        public ActionResult Create(CreateIngredientViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var recipe = _db.Recipes.Single(r => r.Id == model.RecipeId);
                    var newIngredient = new Ingredient()
                    {
                        Name = model.Name,
                        Amount = model.Amount
                    };
                    recipe.Ingredients.Add(newIngredient);
                    _db.Save();

                    return RedirectToAction("details", "Recipe", new { id = model.RecipeId });
                }
                throw new Exception("Form is invalid");
            }
            catch
            {
                return View(model);
            }
        }

        // POST: Ingredient/Edit/5
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

        // POST: Ingredient/Delete/5
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
