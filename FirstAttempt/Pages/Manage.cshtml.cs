using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstAttempt.Pages
{
    public class ManageModel : PageModel
    {
        public List<SelectListItem> CategoryOptions { get; set; } = new List<SelectListItem>();


        [BindProperty]
        public string NewCategoryName { get; set; } = string.Empty;


        public List<Recipe> Recipes { get; set; } = new List<Recipe>
        {
            new Recipe
            {
                Id = 1,
                Title = "Spaghetti Carbonara",
                Category = "Main",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
             new Recipe
            {
                Id = 2,
                Title = "Nikos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 3,
                Title = "Stella",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 4,
                Title = "Giorgos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 5,
                Title = "Amalia",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
                        new Recipe
            {
                Id = 6,
                Title = "Spaghetti Carbonara",
                Category = "Main",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
             new Recipe
            {
                Id = 7,
                Title = "Nikos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 8,
                Title = "Stella",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 9,
                Title = "Giorgos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 10,
                Title = "Amalia",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
                        new Recipe
            {
                Id = 11,
                Title = "Spaghetti Carbonara",
                Category = "Main",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
             new Recipe
            {
                Id = 12,
                Title = "Nikos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 13,
                Title = "Stella",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 14,
                Title = "Giorgos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 15,
                Title = "Amalia",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
                        new Recipe
            {
                Id = 16,
                Title = "Spaghetti Carbonara",
                Category = "Main",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
             new Recipe
            {
                Id = 17,
                Title = "Nikos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 18,
                Title = "Stella",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 19,
                Title = "Giorgos",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
                }
            },
            new Recipe
            {
                Id = 20,
                Title = "Amalia",
                Category = "Dessert",
                Description = "A classic Italian pasta dish.",
                Steps = new List<Step>
                {
                    new Step { Id = 1, Title = "Boil Pasta", Description = "Cook the spaghetti in salted water.", Duration = 10, Images = null, Ingredients = null },
                    new Step { Id = 2, Title = "Prepare Sauce", Description = "Mix eggs and Parmesan cheese.", Duration = 5, Images = null, Ingredients = null }
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
            LoadCategoryOptions();
        }



        private void LoadCategoryOptions()
        {
            CategoryOptions = new List<SelectListItem>();

            foreach (var item in Recipes.DistinctBy(x=>x.Category))
            {
                CategoryOptions.Add(new SelectListItem { Value = item.Category, Text = item.Category });
            }
        }

        public IActionResult OnPost(string? action, int? RecipeId, int? DeleteRecipeId)
        {

            LoadCategoryOptions();

            switch (action)
            {
                case "View":
                    return RedirectToPage("/execute", new { recipeId = RecipeId });
                case "Modify":
                    return RedirectToPage("/EditRecipe", new { recipeId = RecipeId });
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
