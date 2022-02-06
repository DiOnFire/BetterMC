using BetterMC.Core.Installations;
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
                    mod_loader_picture.Source = new BitmapImage(new Uri("/BetterMC;component/Assets/ModLoaders/fabric.png"));
                    break;
                case InstallationType.FORGE:
                    mod_loader_picture.Source = new BitmapImage(new Uri("/BetterMC;component/Assets/ModLoaders/forge.png"));
                    break;
                default:
                    mod_loader_picture.Source = new BitmapImage(new Uri("/BetterMC;component/Assets/ModLoaders/basic.png"));
                    break;
            }
        }
    }
}
