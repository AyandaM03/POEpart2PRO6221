namespace RecipeApplicationTests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void TestTotalCalories()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredient("Sugar", "teaspoon", 1, 16, "Sweets");
            recipe.AddIngredient("Tomato Sauce", "cup", 2, 200);
