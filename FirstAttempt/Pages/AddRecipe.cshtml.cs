using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FirstAttempt.Pages
{
    public class AddRecipeModel : PageModel
    {
        [BindProperty]
        public Recipe Recipe { get; set; }

        [BindProperty]
        public List<IFormFile> Images { get; set; }

        [BindProperty]
        public string NewCategory { get; set; }

        public List<string> Categories { get; set; } = new List<string> { "Breakfast", "Lunch", "Dinner", "Dessert" };

        public void OnGet()
        {
            // Load categories or any necessary data
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add the new category if provided
            if (!string.IsNullOrWhiteSpace(NewCategory) && !Categories.Contains(NewCategory))
            {
                Categories.Add(NewCategory);
                Recipe.Category = NewCategory;
            }

            // Process uploaded files
            if (Images != null && Images.Count > 0)
            {
                foreach (var file in Images)
                {
                    var filePath = Path.Combine("wwwroot/uploads", file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }

            // Save the recipe (add your database logic here)
            // Example:
            // _dbContext.Recipes.Add(Recipe);
            // _dbContext.SaveChanges();

            return RedirectToPage("Index"); // Redirect to a success or list page
        }
    }
}
