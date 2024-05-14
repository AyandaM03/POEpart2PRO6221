
namespace RecipeApplicationTests
{
    internal class Recipe
    {
        private string v;

        public Recipe(string v)
        {
            this.v = v;
        }

        public object Ingredients { get; internal set; }

        internal void AddIngredient(string v1, string v2, int v3, int v4, string v5)
        {
            throw new NotImplementedException();
        }

        internal void AddIngredient(string v1, string v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }

        internal double GetTotalCalories()
        {
            throw new NotImplementedException();
        }

        internal void ScaleRecipe(double v)
        {
            throw new NotImplementedException();
        }
    }
}