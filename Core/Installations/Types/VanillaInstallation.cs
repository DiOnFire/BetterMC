namespace BetterMC.Core.Installations.Types
{
    sealed class VanillaInstallation : Installation
    {
        private string minecraftVersion { get; }

        public VanillaInstallation(string name, string path, string version) : base(name, InstallationType.VANILLA, path)
        {
            this.minecraftVersion = version;
        }
    }
}
