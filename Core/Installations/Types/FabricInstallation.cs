namespace BetterMC.Core.Installations.Types
{
    sealed class FabricInstallation : Installation
    {
        private string fabricVersion { get; }

        public FabricInstallation(string name, string path, string fabricVersion) : base(name, InstallationType.FABRIC, path)
        {
            this.fabricVersion = fabricVersion;
        }
    }
}
