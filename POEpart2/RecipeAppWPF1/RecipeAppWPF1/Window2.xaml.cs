using System.Windows;

namespace RecipeManagerWPF
{
    public partial class AddStepDialog : Window
    {
        public string StepDescription { get; private set; }

        public AddStepDialog()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            StepDescription = txtStepDescription.Text;
            DialogResult = true;
        }
    }
}
