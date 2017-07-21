using System.Linq;

namespace mvcRecipeBook.Domain
{
    public interface IRecipeBookDataSource
    {
        IQueryable<Recipe> Recipes { get; }
        IQueryable<Ingredient> Ingredients { get; }
    }
}
