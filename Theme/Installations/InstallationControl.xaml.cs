using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Types;
using BetterMC.Frontend.Util;
using BetterMC.Theme.Installations.Popup;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BetterMC.Theme.Installations
{
    /// <summary>
    /// Логика взаимодействия для InstallationControl.xaml
    /// </summary>
    public partial class InstallationControl : UserControl
    {
        private Installation installation;
        private InstallationOptionsPopup popup;

        public InstallationControl(Installation installation)
        {
            InitializeComponent();
            this.installation = installation;
            InitComponent();
            popup = new InstallationOptionsPopup(this.installation);
        }

        private void InitComponent()
        {
            installation_name.Text = installation.name;
            installation_version.Text = installation.type.ToString();
            switch (installation.type)
            {
                case InstallationType.FABRIC:
                    mod_loader_picture.Source = new BitmapImage(new Uri("pack://application:,,,/BetterMC;component/Assets/ModLoaders/fabric.png"));
                    installation_version.Text += $" ({((FabricInstallation)installation).fabricVersion})";
                    break;
                case InstallationType.FORGE:
                    mod_loader_picture.Source = new BitmapImage(new Uri("pack://application:,,,/BetterMC;component/Assets/ModLoaders/forge.png"));
                    installation_version.Text += $" ({((ForgeInstallation)installation).forgeVersion})";
                    break;
                default:
                    mod_loader_picture.Source = new BitmapImage(new Uri("pack://application:,,,/BetterMC;component/Assets/ModLoaders/basic.png"));
                    break;
            }
        }

        private void main_grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            main_grid.Background = GlobalColors.GRAY;
        }

        private void main_grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            main_grid.Background = GlobalColors.EMPTY;
        }

        private void additional_options_button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            popup.options_popup.IsOpen = true;
        }
    }
}
