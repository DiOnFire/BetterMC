using BetterMC.Core;
using BetterMC.Core.Installations;
using BetterMC.Core.Installations.Management;
using System.Collections.Generic;

namespace BetterMC.Frontend.ViewModel
{
    class InstallationsViewModel : ObservableObject
    {
        private List<Installation> versions = new List<Installation>();

        public InstallationsViewModel()
        {
            InitVersions();
        }

        private void InitVersions()
        {
            InstallationsLoader loader = new InstallationsLoader();
            string mc = loader.FindMinecraft();
            string[] version = loader.GetVersionPaths(ref mc);
            versions.AddRange(loader.LoadInstallations(version));
        }
    }
}
