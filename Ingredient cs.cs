namespace POEpart2
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
}
