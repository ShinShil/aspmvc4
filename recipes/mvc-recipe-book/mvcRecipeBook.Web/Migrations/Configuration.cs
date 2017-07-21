namespace mvcRecipeBook.Web.Migrations
{
    using mvcRecipeBook.Domain;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcRecipeBook.Web.Infrastructure.RecipeBookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(mvcRecipeBook.Web.Infrastructure.RecipeBookDbContext context)
        {
            context.Recipes.AddOrUpdate(r => r.Id,
                new Recipe()
                {
                    Name = "Student dinner",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_2CAqyCXQmXjqazz1Ge3SUkv-cRock-wZgrhvEF0Is9xRJejR",
                    Description = "Simple dinner that you can easily prepare in 5 minutes."
                },
                new Recipe()
                {
                    Name = "Fish supper",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_2CAqyCXQmXjqazz1Ge3SUkv-cRock-wZgrhvEF0Is9xRJejR",
                    Description = "Tasty supper from fish."
                });
            context.Ingredients.AddOrUpdate(i => i.Name,
                new Ingredient()
                {
                    Name = "Bread",
                    Amount = 5
                },
                new Ingredient()
                {
                    Name = "Milk",
                    Amount = 2
                });
        }
    }
}
