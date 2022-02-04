using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Management;
using System.Collections.Generic;
using System.Windows.Controls;

namespace BetterMC.Frontend.Views
{
    /// <summary>
    /// Логика взаимодействия для InstallationsView.xaml
    /// </summary>
    public partial class InstallationsView : UserControl
    {
        public InstallationsView()
        {
            InitializeComponent();
            InitVersions();
        }

        private void InitVersions()
        {
            InstallationsLoader loader = new InstallationsLoader();
            string mc = loader.FindMinecraft();
            string[] versions = loader.GetVersionPaths(ref mc);
            List<Installation> version = loader.LoadInstallations(versions);
            foreach (Installation i in version)
            {
                ver.Content += $"\n{i.name} / {i.type}";
            }
        }
    }
}
