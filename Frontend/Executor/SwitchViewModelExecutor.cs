﻿using BetterMC.Frontend.Util;
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
        private static readonly Dictionary<string, SolidColorBrush> themes = new Dictionary<string, SolidColorBrush>()
        {
            { "BloomwareViewModel", new SolidColorBrush(Color.FromRgb(164, 11, 191)) },
            { "AltsViewModel", new SolidColorBrush(Color.FromRgb(234, 195, 0)) },
            { "SettingsViewModel", new SolidColorBrush(Color.FromRgb(158, 158, 158)) },
            { "DashboardViewModel", new SolidColorBrush( Color.FromRgb(52, 209, 0)) },
            { "InstallationsViewModel", new SolidColorBrush(Color.FromRgb(52, 209, 0)) },
            { "NewAccountViewModel", new SolidColorBrush( Color.FromRgb(30, 30, 30)) }
        };
        private static readonly SolidColorBrush EMPTY = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

        public static void NewAltButtonClick()
        {
        }

        public static void Execute()
        {
            MainViewModel mainModel = Utils.GetMainViewModel();
            string model = Utils.GetCurrentViewModel().GetType().Name;

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
            MainWindow window = Utils.GetMainWindow();
            string model = Utils.GetCurrentViewModel().GetType().Name;

            ResetConfig(ref window, ref model);

            switch (model)
            {
                case "BloomwareViewModel":
                {
                    window.launch_button.Content = "INSTALL";
                    window.bloomware_left.Background = themes[model];
                    break;
                }
                case "AltsViewModel":
                {
                    window.launch_button.Content = "LOGIN";
                    window.alts_left.Background = themes[model];
                    window.new_alt.Visibility = Visibility.Visible;
                    break;
                }
                case "SettingsViewModel":
                {
                    window.launch_button.Content = "APPLY";
                    window.settings_left.Background = themes[model];
                    break;
                }
                case "DashboardViewModel":
                {
                    window.dashboard_left.Background = themes[model];
                    break;
                }
                case "InstallationsViewModel":
                {
                    window.launch_button.Content = "LAUNCH";
                    window.installations_left.Background = themes[model];
                    window.configure_installation.Visibility = Visibility.Visible;
                    break;
                }
                case "NewAccountViewModel":
                {
                    window.launch_button.Content = "CANCEL";
                    window.launch_button.Background = themes[model];
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
            window.launch_button.Background = themes[model];
            window.alts_left.Background = EMPTY;
            window.bloomware_left.Background = EMPTY;
            window.settings_left.Background = EMPTY;
            window.dashboard_left.Background = EMPTY;
            window.installations_left.Background = EMPTY;
        }
    }
}