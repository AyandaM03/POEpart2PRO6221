using RecipeApplication;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POEpart2
{
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

        // Method to display the scaled recipe
        public void DisplayScaledRecipe(double factor)
        {
            Console.WriteLine($"{Title} (Scaled by {factor}):");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity * factor} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories * factor} calories, {ingredient.FoodGroup})");
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
}


