using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstAttempt.Pages
{
    public class _ViewExecuteModel : PageModel
    {
        public List<Recipe> AvailableRecipes
        {
            get;
            set;
        }
        public Recipe Recipe
        {
            get;
            set;
        }
        public int SelectedRecipeId
        {
            get;
            set;
        }
        public int CurrentStepIndex
        {
            get;
            set;
        } = 1; // Default to step 1
        public Step CurrentStep => Recipe.Steps[CurrentStepIndex - 1];
        public double CurrentProgress => (double)(CurrentStepIndex) / Recipe.Steps.Count * 100;

        public void OnGet(int? recipeId, int? step)
        {
            // Mock Data for Available Recipes
            AvailableRecipes = new List<Recipe> {
                new Recipe {
                    Id = 1,
                        Title = "Spaghetti Carbonara",
                        Category = "main",
                        Description = "Classic Italian pasta dish",

                        Steps = new List < Step > {
                            new() {
                                Id = 1, Title = "Prepare Ingredients", Description = "Grate the cheese and cut the guanciale into small cubes.",
                                Duration = 5,
                                Images = new List < string > {
                                        "/images/supermarket.jpg",
                                        "/images/supermarket.jpg",
                                        "/images/cheese.jpg"
                                    },
                                Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Spaghetti", Quantity = "400g"
                                        },
                                        new() {
                                            Id = 2, Name = "Eggs", Quantity = "3 large"
                                        },
                                        new() {
                                            Id = 3, Name = "Pecorino Romano", Quantity = "100g"
                                        },
                                        new() {
                                            Id = 4, Name = "Guanciale", Quantity = "150g"
                                        },
                                        new() {
                                            Id = 5, Name = "Nikos", Quantity = "150g"
                                        },
                                    }
                            },
                            new() {
                                Id = 2, Title = "Cook Pasta", Description = "Boil the pasta in salted water according to package instructions.",
                                Duration = 10,
                                Images = new List < string > {
                                    "/images/nodata.jpg",
                                    "/images/nodata.jpg",
                                    "/images/cheese.jpg"
                                },
                                Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Spaghetti", Quantity = "400g"
                                        },
                                        new() {
                                            Id = 2, Name = "Eggs", Quantity = "3 large"
                                        },
                                        new() {
                                            Id = 3, Name = "Pecorino Romano", Quantity = "100g"
                                        },
                                        new() {
                                            Id = 4, Name = "Guanciale", Quantity = "150g"
                                        },
                                    }
                            },
                            new() {
                                Id = 3, Title = "Prepare Sauce",
                                Description = "Mix eggs, cheese, and black pepper in a bowl.",
                                Duration = 5,
                                Images = new List < string > {
                                    "/images/supermarket.jpg",
                                    "/images/nodata.jpg",
                                    "/images/cheese.jpg"
                                },
                                Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Spaghetti", Quantity = "400g"
                                        },
                                        new() {
                                            Id = 2, Name = "Eggs", Quantity = "3 large"
                                        },
                                        new() {
                                            Id = 3, Name = "Pecorino Romano", Quantity = "100g"
                                        },
                                        new() {
                                            Id = 4, Name = "Guanciale", Quantity = "150g"
                                        },
                                    }
                            }
                        }
                },
                new Recipe {
                    Id = 2,
                        Title = "Margherita Pizza",
                        Category = "main",
                        Description = "Classic Italian pizza with fresh tomatoes, mozzarella, and basil",
                        Steps = new List < Step > {
                            new() {
                                Id = 1, Title = "Prepare Dough", Description = "Roll out the pizza dough.", Duration = 5, Images = new List < string > {
                                        "/images/supermarket.jpg",
                                        "/images/supermarket.jpg",
                                        "/images/cheese.jpg"
                                    },
                                    Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Pizza Dough", Quantity = "1 base"
                                        },
                                        new() {
                                            Id = 2, Name = "Tomato Sauce", Quantity = "200ml"
                                        },
                                        new() {
                                            Id = 3, Name = "Mozzarella Cheese", Quantity = "200g"
                                        },
                                        new() {
                                            Id = 4, Name = "Fresh Basil", Quantity = "a handful"
                                        },
                                    }
                            },
                            new() {
                                Id = 2, Title = "Add Toppings", Description = "Spread tomato sauce and sprinkle cheese.", Duration = 5, Images = new List < string > {
                                        "/images/nodata.jpg",
                                        "/images/nodata.jpg",
                                        "/images/cheese.jpg"
                                    },
                                    Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Pizza Dough", Quantity = "1 base"
                                        },
                                        new() {
                                            Id = 2, Name = "Tomato Sauce", Quantity = "200ml"
                                        },
                                        new() {
                                            Id = 3, Name = "Mozzarella Cheese", Quantity = "200g"
                                        },
                                        new() {
                                            Id = 4, Name = "Fresh Basil", Quantity = "a handful"
                                        },
                                    }
                            },
                            new() {
                                Id = 3, Title = "Bake", Description = "Bake the pizza in a preheated oven at 220°C for 12-15 minutes.",
                                Duration = 15,
                                Images = new List < string > {
                                        "/images/supermarket.jpg",
                                        "/images/nodata.jpg",
                                        "/images/cheese.jpg"
                                    },
                                Ingredients = new List < Ingredient > {
                                        new() {
                                            Id = 1, Name = "Pizza Dough", Quantity = "1 base"
                                        },
                                        new() {
                                            Id = 2, Name = "Tomato Sauce", Quantity = "200ml"
                                        },
                                        new() {
                                            Id = 3, Name = "Mozzarella Cheese", Quantity = "200g"
                                        },
                                        new() {
                                            Id = 4, Name = "Fresh Basil", Quantity = "a handful"
                                        },
                                    }
                            }
                        }
                }
            };

            if (recipeId.HasValue)
            {
                // Set Selected Recipe
                SelectedRecipeId = recipeId.Value;
                Recipe = AvailableRecipes.FirstOrDefault(r => r.Id == SelectedRecipeId);

                // Determine Current Step
                if (step.HasValue && step > 0 && step <= Recipe?.Steps.Count)
                {
                    CurrentStepIndex = step.Value;
                }
            }
        }
    }

    public class Recipe
    {
        public int Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }

        public List<Step> Steps
        {
            get;
            set;
        }
    }

    public class Ingredient
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Quantity
        {
            get;
            set;
        }
    }

    public class Step
    {
        public int Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int Duration
        {
            get;
            set;
        }
        public List<string> Images
        {
            get;
            set;
        } // Changed to a list of images

        public List<Ingredient> Ingredients
        {
            get;
            set;
        }
    }
}