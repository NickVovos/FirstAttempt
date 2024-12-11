using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstAttempt.Pages
{
    public class RecipePageModel : PageModel
    {
        // Properties for the page
        [BindProperty]
        public string SelectedRecipeId { get; set; }

        public List<SelectListItem> RecipeList { get; set; }

        public Recipe SelectedRecipe { get; set; }

        private static readonly List<Recipe> AllRecipes = new List<Recipe>
        {
            new Recipe
            {
                Id = 1,
                Description = "Spaghetti Bolognese",
                Images = new List<string>
                {
                    "/images/nodata.jpg",
                    "/images/nodata.jpg"
                }
            },
            new Recipe
            {
                Id = 2,
                Description = "Chicken Curry",
                Images = new List<string>
                {
                    "/images/nodata.jpg",
                    "/images/nodata.jpg"
                }
            },
            new Recipe
            {
                Id = 3,
                Description = "Vegetable Stir Fry",
                Images = new List<string>
                {
                    "/images/nodata.jpg",
                    "/images/nodata.jpg"
                }
            }
        };

        public void OnGet(string recipeId = null)
        {
            RecipeList = AllRecipes
                .Select(recipe => new SelectListItem
                {
                    Value = recipe.Id.ToString(),
                    Text = recipe.Description
                })
                .ToList();

            if (!string.IsNullOrEmpty(recipeId))
            {
                SelectedRecipe = AllRecipes.FirstOrDefault(r => r.Id.ToString() == recipeId);
                SelectedRecipeId = recipeId;
            }
        }
    }

}
