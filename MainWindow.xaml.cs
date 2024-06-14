using System.Windows;

namespace PPart_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            var recipeCreatorWindow = new RecipeCreator();
            recipeCreatorWindow.Show();
        }

        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            var recipeCollectionWindow = new RecipeCollection();
            recipeCollectionWindow.Show();
        }

        private void ViewSpecificRecipe_Click(object sender, RoutedEventArgs e)
        {
            var recipeViewerWindow = new RecipeViewer();
            recipeViewerWindow.Show();
        }
    }
}

