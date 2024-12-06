using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstAttempt.Pages
{
    public class ManageModel : PageModel
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>
    {
        new Recipe
        {
            Id = 1,
            Title = "Spaghetti Carbonara",
            Category = "Main",
            Description = "A classic Italian pasta dish.",
            Ingredients = new List<Ingredient>
            {
                new Ingredient { Id = 1, Name = "Spaghetti", Quantity = "200g" },
                new Ingredient { Id = 2, Name = "Eggs", Quantity = "2" },
                new Ingredient { Id = 3, Name = "Parmesan Cheese", Quantity = "50g" }
            },
            Steps = new List<Step>
            {
                new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Image = "" },
                new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Image = "" }
            }
        }
    };

        public List<Recipe> FilteredRecipes => Recipes
            .Where(r => (string.IsNullOrWhiteSpace(SearchTerm) || r.Title.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase))
                        && (CategoryFilter == "all" || r.Category.Equals(CategoryFilter, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        [BindProperty]
        public string SearchTerm { get; set; } = string.Empty;

        [BindProperty]
        public string CategoryFilter { get; set; } = "all";

        public Recipe? RecipeToDelete { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string? action, int? RecipeId, int? DeleteRecipeId)
        {
            switch (action)
            {
                case "View":
                    return RedirectToPage("/execute", new { id = RecipeId });
                case "Modify":
                    return RedirectToPage("/EditRecipe", new { id = RecipeId });
                case "Delete":
                    RecipeToDelete = Recipes.FirstOrDefault(r => r.Id == RecipeId);
                    break;
                case "ConfirmDelete":
                    if (DeleteRecipeId.HasValue)
                    {
                        Recipes.RemoveAll(r => r.Id == DeleteRecipeId.Value);
                    }
                    break;
                case "Cancel":
                    RecipeToDelete = null;
                    break;
            }
            return Page();
        }
    }
}
