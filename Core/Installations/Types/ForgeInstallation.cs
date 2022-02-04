﻿namespace BetterMC.Core.Installations.Types
{
    sealed class ForgeInstallation : Installation
    {
        private string forgeVersion { get; }

        public ForgeInstallation(string name, string path, string forgeVersion) : base(name, InstallationType.FORGE, path)
        {
            this.forgeVersion = forgeVersion;
        }
    }
}
