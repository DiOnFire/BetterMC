using BetterMC.Frontend.ViewModel;
using System.Windows;
using System.Windows.Media;
using static System.Windows.Application;

namespace BetterMC.Frontend.Executor
{
    /*
     * Executor of Main button
     * Changes properties of button (like text or color)
     * Executes button's command
     */
    class DownPanelExecutor
    {
        /*
         * Executes button's command
         */
        public static void Execute()
        {
        }

        /*
         * Changes properties of button
         */
        public static void SwitchViewModel()
        {
            MainWindow window = Current.MainWindow as MainWindow;
            window.new_alt.Visibility = Visibility.Hidden;
            window.configure_installation.Visibility = Visibility.Hidden;
            
            switch ((window?.DataContext as MainViewModel)?.CurrentView.GetType().Name)
            {
                case "BloomwareViewModel":
                {
                    window.launch_button.Content = "INSTALL";
                    window.launch_button.Background = new SolidColorBrush(Color.FromRgb(164, 11, 191));
                    break;
                }
                case "AltsViewModel":
                {
                    window.launch_button.Content = "LOGIN";
                    window.launch_button.Background = new SolidColorBrush(Color.FromRgb(234, 195, 0));
                    window.new_alt.Visibility = Visibility.Visible;
                    break;
                }
                case "SettingsViewModel":
                {
                    window.launch_button.Content = "APPLY";
                    window.launch_button.Background = new SolidColorBrush(Color.FromRgb(158, 158, 158));
                    break;
                }
                case "DashboardViewModel":
                case "InstallationsViewModel":
                {
                    window.launch_button.Content = "LAUNCH";
                    window.launch_button.Background = new SolidColorBrush(Color.FromRgb(52, 209, 0));
                    window.configure_installation.Visibility = Visibility.Visible;    
                    break;
                }
            }
        }
    }
}