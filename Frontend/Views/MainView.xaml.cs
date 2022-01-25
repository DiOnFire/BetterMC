using System.Windows.Controls;
using static System.Windows.Application;
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
            ((MainWindow) Current.MainWindow).bloomware_left.IsChecked = true;
            ((MainWindow) Current.MainWindow).bloomware_left.Command.Execute(0);
        }

        /*
         * Executes when you click the Settings border.
         * Opens settings page in left menu.
         */
        private void OnSettingBoardMouseClick(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow) Current.MainWindow).settings_left.IsChecked = true;
            ((MainWindow) Current.MainWindow).settings_left.Command.Execute(0);
        }

        /*
         * Executes when you click the Installations border.
         * Opens installations page in left menu.
         */
        private void OnInstallationsBorderMouseClick(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow) Current.MainWindow).installations_left.IsChecked = true;
            ((MainWindow) Current.MainWindow).installations_left.Command.Execute(0);
        }

        /*
         * Executes when you click the Alts border.
         * Opens alts page in left menu.
         */
        private void OnAltsBorderMouseClick(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow) Current.MainWindow).alts_left.IsChecked = true;
            ((MainWindow) Current.MainWindow).alts_left.Command.Execute(0);
        }
    }
}
