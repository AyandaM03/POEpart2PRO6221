# POEpart2
Recipe Application

This is a command-line application written in C# that allows users to create, display, and scale recipes.

.NET Core SDK were installed on my machine to run this.
How to Compile and Run

Clone the repository to your local machine:

Compile the code using the .NET CLI:

Run the application:

Usage

Once the app runs, you can follow the on-screen intructions to enter the details for a recipe. You can add ingredients, specify quantities and units, add steps, display the recipe, and scale it by a factor of 0.5, 2, or 3.

PART 2 UPDATED README 

How to Compile and Run the Recipe Application Software
Description:
The Recipe Application is a console-based application that allows users to manage multiple recipes, each with its ingredients and steps. It includes features such as scaling recipes, calculating total calories, and alerting when the calorie limit exceeds 300 calories.

Source Code Overview

- Ingredient Class: Stores details about individual ingredients.
- Recipe Class: Manages the recipe's ingredients, steps, and total calorie calculation.
- RecipeBook Class: Manages a collection of recipes and provides methods to add, list, and retrieve recipes.
- Program Class: Contains the main method to run the application, allowing users to add ingredients and steps to recipes, list all recipes, and view specific recipes.

Compiling and Running the Software

1. Open the Solution in Visual Studio:
   - Open Visual Studio.
   - Go to `File > Open > Project/Solution`.
   - Navigate to the directory containing `RecipeApplication.sln` and open it.

2. Build the Solution:
   - Select `Build > Build Solution` or press `Ctrl+Shift+B`.
   - Ensure there are no build errors.

3. Run the Application:
   - Set `RecipeApplication` as the startup project by right-clicking it in Solution Explorer and selecting `Set as StartUp Project`.
   - Press `F5` to run the application or go to `Debug > Start Debugging`.

4. Running Unit Tests:
   - Open `Test Explorer` from `Test > Test Explorer`.
   - Click `Run All` to execute the unit tests and verify the functionality.

#### Example Commands in the Application

1. Adding a Recipe:
   - Enter ingredients, steps, and scale a recipe by 0.5 to view both original and scaled versions.

2. Displaying All Recipes:
   - Lists all recipe titles in alphabetical order.

3. Viewing a Specific Recipe:
   - Enter the recipe name when prompted to display its details and steps.

FEEDBACK DESCRIPTION:
Enhanced Recipe Management:
Added functionality to handle multiple recipes, allowing users to enter an unlimited number of recipes and display them in alphabetical order.
Calorie Management:
Incorporated additional fields for ingredients such as calories and food group, and implemented calorie calculation with an alert when total calories exceed 300.
Refactored Code:
Refactored the code to use generic collections instead of arrays for better scalability and maintainability.
Unit Tests:
Created unit tests using NUnit to ensure the accuracy of the total calorie calculation and other functionalities.
The git hub file and part on of the project was not able to open and the feedback given was that it wasnt submitted im hoping that with the new resposotory it works.

link to my github : https://github.com/AyandaM03/POEpart2PRO6221.git
