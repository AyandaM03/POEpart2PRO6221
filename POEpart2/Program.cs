using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeApplication
{
    // Class to store ingredient details
    class Ingredient
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, string unit, double quantity, double calories, string foodGroup)
        {
            Name = name;
            Unit = unit;
            Quantity = quantity;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }

    // Class to store recipe details
    class Recipe
    {
        public string Title { get; set; }
        private List<Ingredient> ingredients;
        private List<string> steps;

        public delegate void CalorieAlertHandler(string message);
        public event CalorieAlertHandler OnCalorieAlert;

        public Recipe(string title)
        {
            Title = title;
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        // Method to add an ingredient
        public void AddIngredient(string name, string unit, double quantity, double calories, string foodGroup)
        {
            ingredients.Add(new Ingredient(name, unit, quantity, calories, foodGroup));
            if (GetTotalCalories() > 300)
            {
                OnCalorieAlert?.Invoke($"The recipe '{Title}' exceeds 300 calories.");
            }
        }

        // Method to add a step
        public void AddStep(string step)
        {
            steps.Add(step);
        }

        // Method to display the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine($"{Title}:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        // Method to calculate total calories
        public double GetTotalCalories()
        {
            return ingredients.Sum(i => i.Calories * i.Quantity);
        }

        // Method to scale the recipe
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to clear the recipe data
        public void ClearData()
        {
            ingredients.Clear();
            steps.Clear();
        }
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new RecipeBook();

            // Creating a new recipe
            Recipe recipe = new Recipe("Chakalaka");

            // Subscribe to calorie alert event
            recipe.OnCalorieAlert += message => Console.WriteLine(message);

            // Adding ingredients
            recipe.AddIngredient("Sugar", "teaspoon", 1, 16, "Sweets");
            recipe.AddIngredient("Tomato Sauce", "cup", 2, 200, "Condiments");
            recipe.AddIngredient("Grated Carrot", "cup", 3, 50, "Vegetables");
            recipe.AddIngredient("Koo canned baked beans", "can", 3, 100, "Legumes");
            recipe.AddIngredient("Spices of choice", "teaspoon", 4, 5, "Spices");
            recipe.AddIngredient("Chopped onions and peppers", "cup", 2, 30, "Vegetables");

            // Adding steps
            recipe.AddStep("Add oil to a pan and fry the onions and peppers till brown.");
            recipe.AddStep("Add grated carrots and season with the sugar and spices you choose.");
            recipe.AddStep("Pour the tomato sauce and koo baked beans and let the chakalaka simmer for 15 minutes.");

            // Adding recipe to the recipe book
            recipeBook.AddRecipe(recipe);

            // Displaying all recipes
            Console.WriteLine("All Recipes:");
            recipeBook.DisplayAllRecipes();

            // Displaying a specific recipe
            Console.WriteLine("\nEnter the recipe name to display:");
            string recipeName = Console.ReadLine();
            Recipe selectedRecipe = recipeBook.GetRecipeByTitle(recipeName);
            if (selectedRecipe != null)
            {
                selectedRecipe.DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }

            // Scaling the recipe and displaying it again
            selectedRecipe.ScaleRecipe(0.5);
            Console.WriteLine("\nScaled Recipe:");
            selectedRecipe.DisplayRecipe();
        }
    }
}
