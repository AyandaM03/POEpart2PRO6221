using System.Windows;

namespace RecipeManagerWPF
{
    public partial class AddIngredientDialog : Window
    {
        public string IngredientName { get; private set; }
        public double Quantity { get; private set; }
        public string Unit { get; private set; }
        public double Calories { get; private set; }
        public string FoodGroup { get; private set; }

        public AddIngredientDialog()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            IngredientName = txtIngredientName.Text;
            Quantity = double.Parse(txtQuantity.Text);
            Unit = txtUnit.Text;
            Calories = double.Parse(txtCalories.Text);
            FoodGroup = txtFoodGroup.Text;
            DialogResult = true;
        }
    }
}
