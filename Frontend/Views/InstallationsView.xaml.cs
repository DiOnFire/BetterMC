using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Management;
using BetterMC.Theme.Installations;
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
            InitChildren();
        }

        private void InitChildren()
        {
            InstallationsLoader loader = new InstallationsLoader();
            string mc = loader.FindMinecraft();
            string[] versions = loader.GetVersionPaths(ref mc);
            List<Installation> version = loader.LoadInstallations(versions);
            for (int i = 0; i < version.Count; i++)
            {
                int index = installations_panel.Children.Count;
                installations_panel.Children.Insert(index, new InstallationControl(version[i]));
            }
        }
    }
}
