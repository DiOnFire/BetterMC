using BetterMC.Core.Installations;
using BetterMC.Frontend.Util;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;

namespace BetterMC.Theme.Installations.Popup
{
    /// <summary>
    /// Логика взаимодействия для InstallationOptionsPopup.xaml
    /// </summary>
    public partial class InstallationOptionsPopup : UserControl
    {
        public Installation installation;

        public InstallationOptionsPopup(Installation installation)
        {
            this.installation = installation;
            InitializeComponent();
        }

        private void delete_installation_MouseEnter(object sender, MouseEventArgs e)
        {
            delete_installation.Background = GlobalColors.GRAY;
        }

        private void open_installation_path_MouseEnter(object sender, MouseEventArgs e)
        {
            open_installation_path.Background = GlobalColors.GRAY;
        }

        private void installation_settings_MouseEnter(object sender, MouseEventArgs e)
        {
            installation_settings.Background = GlobalColors.GRAY;
        }

        private void installation_settings_MouseLeave(object sender, MouseEventArgs e)
        {
            installation_settings.Background = GlobalColors.LIGHT_GRAY;
        }

        private void open_installation_path_MouseLeave(object sender, MouseEventArgs e)
        {
            open_installation_path.Background = GlobalColors.LIGHT_GRAY;
        }

        private void delete_installation_MouseLeave(object sender, MouseEventArgs e)
        {
            delete_installation.Background = GlobalColors.LIGHT_GRAY;
        }

        private void open_installation_path_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "/select, \"" + installation.Path + "\"");
        }
    }
}
