using mvcRecipeBook.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcRecipeBook.Web.Infrastructure
{
    public class RecipeBookDbContext : DbContext, IRecipeBookDataSource
    {
        public RecipeBookDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        IQueryable<Recipe> IRecipeBookDataSource.Recipes
        {
            get
            {
                return Recipes;
            }
        }

        IQueryable<Ingredient> IRecipeBookDataSource.Ingredients
        {
            get
            {
                return Ingredients;
            }
        }
    }
}