using System.Collections.Generic;

namespace mvcRecipeBook.Domain
{
    public class Recipe
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
