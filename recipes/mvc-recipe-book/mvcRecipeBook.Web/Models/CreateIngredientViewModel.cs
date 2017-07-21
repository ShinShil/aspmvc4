using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcRecipeBook.Web.Models
{
    public class CreateIngredientViewModel
    {
        public string RecipeName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int RecipeId { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The ingredient name is too long")]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than zero")]
        public int Amount { get; set; }
    }
}