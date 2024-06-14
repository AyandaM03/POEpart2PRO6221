using System;
using System.Collections.Generic;
using System.Linq;

namespace POEpart2
{
    // Class to manage multiple recipes
    class RecipeBook
    {
        private List<Recipe> recipes;

        public RecipeBook()
        {
            recipes = new List<Recipe>();
        }

        // Method to add a recipe
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        // Method to display all recipe titles
        public void DisplayAllRecipes()
        {
            foreach (var recipe in recipes.OrderBy(r => r.Title))
            {
                Console.WriteLine(recipe.Title);
            }
        }

        // Method to get a recipe by title
        public Recipe GetRecipeByTitle(string title)
        {
            return recipes.FirstOrDefault(r => r.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
