﻿using System;

namespace POEpart2
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new RecipeBook();

            // Adding the original Chakalaka recipe
            Recipe chakalakaRecipe = new Recipe("Chakalaka");

            // Subscribe to calorie alert event
            chakalakaRecipe.OnCalorieAlert += message => Console.WriteLine(message);

            // Adding ingredients
            chakalakaRecipe.AddIngredient("Sugar", "teaspoon", 1, 16, "Sweets");
            chakalakaRecipe.AddIngredient("Tomato Sauce", "cup", 2, 200, "Condiments");
            chakalakaRecipe.AddIngredient("Grated Carrot", "cup", 3, 50, "Vegetables");
            chakalakaRecipe.AddIngredient("Koo canned baked beans", "can", 3, 100, "Legumes");
            chakalakaRecipe.AddIngredient("Spices of choice", "teaspoon", 4, 5, "Spices");
            chakalakaRecipe.AddIngredient("Chopped onions and peppers", "cup", 2, 30, "Vegetables");

            // Adding steps
            chakalakaRecipe.AddStep("Add oil to a pan and fry the onions and peppers till brown.");
            chakalakaRecipe.AddStep("Add grated carrots and season with the sugar and spices you choose.");
            chakalakaRecipe.AddStep("Pour the tomato sauce and koo baked beans and let the chakalaka simmer for 15 minutes.");

            // Adding the original recipe to the recipe book
            recipeBook.AddRecipe(chakalakaRecipe);

            // Menu for user interaction
            string userChoice;

            do
            {
                Console.WriteLine("Recipe Application Menu:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Display a specific recipe");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        // Add a new recipe
                        Console.Write("Enter the recipe name: ");
                        string recipeName = Console.ReadLine();
                        Recipe newRecipe = new Recipe(recipeName);

                        // Subscribe to calorie alert event
                        newRecipe.OnCalorieAlert += message => Console.WriteLine(message);

                        // Add ingredients
                        string addMoreIngredients;
                        do
                        {
                            Console.Write("Enter ingredient name: ");
                            string ingredientName = Console.ReadLine();
                            Console.Write("Enter unit (e.g., teaspoon, cup): ");
                            string unit = Console.ReadLine();
                            Console.Write("Enter quantity: ");
                            double quantity = double.Parse(Console.ReadLine());
                            Console.Write("Enter calories per unit: ");
                            double calories = double.Parse(Console.ReadLine());
                            Console.Write("Enter food group: ");
                            string foodGroup = Console.ReadLine();

                            newRecipe.AddIngredient(ingredientName, unit, quantity, calories, foodGroup);

                            Console.Write("Do you want to add another ingredient? (yes/no): ");
                            addMoreIngredients = Console.ReadLine();
                        } while (addMoreIngredients.ToLower() == "yes");

                        // Add steps
                        string addMoreSteps;
                        do
                        {
                            Console.Write("Enter step description: ");
                            string step = Console.ReadLine();
                            newRecipe.AddStep(step);

                            Console.Write("Do you want to add another step? (yes/no): ");
                            addMoreSteps = Console.ReadLine();
                        } while (addMoreSteps.ToLower() == "yes");

                        recipeBook.AddRecipe(newRecipe);
                        break;

                    case "2":
                        // Display all recipes
                        Console.WriteLine("All Recipes:");
                        recipeBook.DisplayAllRecipes();
                        break;

                    case "3":
                        // Display a specific recipe
                        Console.WriteLine("Enter the recipe name to display:");
                        string selectedRecipeName = Console.ReadLine();
                        Recipe selectedRecipe = recipeBook.GetRecipeByTitle(selectedRecipeName);
                        if (selectedRecipe != null)
                        {
                            selectedRecipe.DisplayRecipe();
                            Console.WriteLine("\nScaled Recipe (0.5):");
                            selectedRecipe.DisplayScaledRecipe(0.5);
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;

                    case "4":
                        // Exit
                        Console.WriteLine("Exiting the application.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (userChoice != "4");
        }
    }
}
