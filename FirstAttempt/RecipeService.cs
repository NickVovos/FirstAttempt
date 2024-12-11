using FirstAttempt.Pages;

namespace FirstAttempt
{
    public class RecipeService
    {
        private static List<Recipe> _recipes = new List<Recipe>
    {
        new Recipe
        {
            Id = 1,
            Title = "Pasta",
            Category = "Main Course",
            Description = "Delicious homemade pasta",
                   Images = new List<string>
                    {
                        "/images/supermarket.jpg",
                        "/images/nodata.jpg"
                    },
            Steps = new List<Step>
            {
                new Step { Id = 1, Title = "Boil Water", Description = "Boil the water for pasta", Duration = 10, Ingredients = new List<Ingredient>() }
            }
        },
        new Recipe
        {
            Id = 2,
            Title = "Cake",
            Category = "Dessert",
            Description = "Yummy chocolate cake",
                       Images = new List<string>
                    {
                        "/images/supermarket.jpg",
                        "/images/nodata.jpg"
                    },
            Steps = new List<Step>
            {
                new Step { Id = 1, Title = "Preheat Oven", Description = "Preheat the oven to 350F", Duration = 5, Ingredients = new List<Ingredient>() }
            }
        }
    };

        public List<Recipe> GetAllRecipes()
        {
            return _recipes;
        }

        public List<string> GetCategories()
        {
            // Return unique categories from the recipes
            return _recipes.Select(r => r.Category).Distinct().ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _recipes.FirstOrDefault(r => r.Id == id);
        }
    }


}
