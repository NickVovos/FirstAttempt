using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstAttempt.Pages
{
    public class _ViewExecuteModel : PageModel
    {
        public Recipe Recipe { get; set; }
        public int CurrentStepIndex { get; set; } = 1; // Default to step 1
        public Step CurrentStep => Recipe.Steps[CurrentStepIndex - 1];
        public double CurrentProgress => (double)(CurrentStepIndex) / Recipe.Steps.Count * 100;


        public void OnGet(int? step)
        {
            // Mock Recipe Data
            Recipe = new Recipe
            {
                Id = 1,
                Title = "Spaghetti Carbonara",
                Category = "main",
                Description = "Classic Italian pasta dish",
                Ingredients = new List<Ingredient>
            {
                new() { Id = 1, Name = "Spaghetti", Quantity = "400g" },
                new() { Id = 2, Name = "Eggs", Quantity = "3 large" },
                new() { Id = 3, Name = "Pecorino Romano", Quantity = "100g" },
                new() { Id = 4, Name = "Guanciale", Quantity = "150g" },
            },
                Steps = new List<Step>
            {
                new() { Id = 1, Title = "Prepare Ingredients", Description = "Grate the cheese and cut the guanciale into small cubes.", Duration = 5, Image = "/images/supermarket.jpg" },
                new() { Id = 2, Title = "Cook Pasta", Description = "Boil the pasta in salted water according to package instructions.", Duration = 10, Image = "/images/supermarket.jpg" },
                new() { Id = 3, Title = "Prepare Sauce", Description = "Mix eggs, cheese, and black pepper in a bowl.", Duration = 5, Image = "/images/supermarket.jpg" },
            }
            };

            // Determine current step
            if (step.HasValue && step > 0 && step <= Recipe.Steps.Count)
            {
                CurrentStepIndex = step.Value;
            }
        }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
    }

    public class Step
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Image { get; set; }
    }
}
