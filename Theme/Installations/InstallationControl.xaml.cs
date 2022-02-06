using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Types;
using BetterMC.Frontend.Util;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BetterMC.Theme.Installations
{
    /// <summary>
    /// Логика взаимодействия для InstallationControl.xaml
    /// </summary>
    public partial class InstallationControl : UserControl
    {
        private Installation _installation;

        public InstallationControl(Installation installation)
        {
            InitializeComponent();
            this._installation = installation;
            InitComponent();
        }

        private void InitComponent()
        {
            installation_name.Text = _installation.name;
            installation_version.Text = _installation.type.ToString();
            switch (_installation.type)
            {
                case InstallationType.FABRIC:
                    mod_loader_picture.Source = new BitmapImage(new Uri("pack://application:,,,/BetterMC;component/Assets/ModLoaders/fabric.png"));
                    installation_version.Text += $" ({((FabricInstallation)_installation).fabricVersion})";
                    break;
                case InstallationType.FORGE:
                    mod_loader_picture.Source = new BitmapImage(new Uri("pack://application:,,,/BetterMC;component/Assets/ModLoaders/forge.png"));
                    installation_version.Text += $" ({((ForgeInstallation)_installation).forgeVersion})";
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
    }
}
