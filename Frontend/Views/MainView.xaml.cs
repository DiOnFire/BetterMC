using System.Windows.Controls;
using System.Windows.Input;

namespace BetterMC.Frontend.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        /*
         * Executes when you click the GitHub border.
         * Opens repository link in default browser.
         */ 
        private void OnGitHubBorderClick(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DiOnFire/BetterMC");
        }

        /*
         * Executes when you click the Bloomware border.
         * Opens Bloomware page in left menu.
         */ 
        private void OnBloomwareButtonMouseClick(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).bloomware_left.IsChecked = true;
            ((MainWindow)System.Windows.Application.Current.MainWindow).bloomware_left.Command.Execute(0);
        }
    }
}
