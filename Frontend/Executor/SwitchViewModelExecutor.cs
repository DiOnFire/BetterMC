using BetterMC.Frontend.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using static System.Windows.Application;

namespace BetterMC.Frontend.Executor
{
    /*
     * View model switcher
     * Changes properties of current view model
     * Executes when view model changes via relay command
     */
    public static class SwitchViewModelExecutor
    {
        private static readonly Dictionary<string, Color> themes = new Dictionary<string, Color>()
        {
            { "BloomwareViewModel", Color.FromRgb(164, 11, 191) },
            { "AltsViewModel", Color.FromRgb(234, 195, 0) },
            { "SettingsViewModel", Color.FromRgb(158, 158, 158) },
            { "DashboardViewModel", Color.FromRgb(52, 209, 0) },
            { "InstallationsViewModel", Color.FromRgb(52, 209, 0) },
            { "NewAccountViewModel", Color.FromRgb(234, 195, 0) }
        };
        private static readonly SolidColorBrush EMPTY = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

        public static void NewAltButtonClick()
        {
        }

        public static void Execute()
        {
            MainWindow window = Current.MainWindow as MainWindow;
            MainViewModel mainModel = window?.DataContext as MainViewModel;
            string model = mainModel?.CurrentView.GetType().Name;

            switch (model)
            {
                case "NewAccountViewModel":
                    {
                        mainModel.CurrentView = mainModel.AltsView;
                        break;
                    }
                
            }
        }

        public static void SwitchViewModel()
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
                case "NewAccountViewModel":
                {
                    window.launch_button.Content = "CANCEL";
                        window.launch_button.Background = new SolidColorBrush(Colors.Black);
                    break;
                }
                default:
                {
                    ResetConfig(ref window, ref model);
                    break;
                }
            }
        }

        private static void ResetConfig(ref MainWindow window, ref string model)
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