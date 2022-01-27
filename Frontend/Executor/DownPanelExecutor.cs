using BetterMC.Frontend.ViewModel;
using System.Collections.Generic;
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
    sealed class DownPanelExecutor
    {
        private readonly Dictionary<string, Color> themes = new Dictionary<string, Color>();
        private readonly SolidColorBrush EMPTY = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

        public DownPanelExecutor()
        {
            themes.Add("BloomwareViewModel", Color.FromRgb(164, 11, 191));
            themes.Add("AltsViewModel", Color.FromRgb(234, 195, 0));
            themes.Add("SettingsViewModel", Color.FromRgb(158, 158, 158));
            themes.Add("DashboardViewModel", Color.FromRgb(52, 209, 0));
            themes.Add("InstallationsViewModel", Color.FromRgb(52, 209, 0));
        }

        /*
         * Executes button's command
         */
        public void Execute()
        {
        }

        public void SwitchViewModel()
        {
            MainWindow window = Current.MainWindow as MainWindow;
            string model = (window?.DataContext as MainViewModel)?.CurrentView.GetType().Name;

            ResetConfig(ref window, ref model);
            
            switch (model)
            {
                case "BloomwareViewModel":
                {
                    window.launch_button.Content = "INSTALL";
                    window.bloomware_left.Background = new SolidColorBrush(themes[model]);
                    break;
                }
                case "AltsViewModel":
                {
                    window.launch_button.Content = "LOGIN";
                    window.alts_left.Background = new SolidColorBrush(themes[model]);
                    window.new_alt.Visibility = Visibility.Visible;
                    break;
                }
                case "SettingsViewModel":
                {
                    window.launch_button.Content = "APPLY";
                    window.settings_left.Background = new SolidColorBrush(themes[model]);
                    break;
                }
                case "DashboardViewModel":
                {
                    window.dashboard_left.Background = new SolidColorBrush(themes[model]);
                    break;
                }
                case "InstallationsViewModel":
                {
                    window.launch_button.Content = "LAUNCH";
                    window.installations_left.Background = new SolidColorBrush(themes[model]);
                    window.configure_installation.Visibility = Visibility.Visible;    
                    break;
                }
            }
        }

        /*
         * Private method for resetting the colors when you are switching view model
         */ 
        private void ResetConfig(ref MainWindow window, ref string model)
        {
            window.new_alt.Visibility = Visibility.Hidden;
            window.configure_installation.Visibility = Visibility.Hidden;
            window.launch_button.Background = new SolidColorBrush(themes[model]);
            window.alts_left.Background = EMPTY;
            window.bloomware_left.Background = EMPTY;
            window.settings_left.Background = EMPTY;
            window.dashboard_left.Background = EMPTY;
            window.installations_left.Background = EMPTY;
        }
    }
}