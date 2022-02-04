using BetterMC.Core.Installations.Types;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace BetterMC.Core.Installations.Management
{
    sealed class InstallationsLoader
    {
        public string FindMinecraft()
        {
            string mcPath = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\.minecraft");
            return Directory.Exists(mcPath) ? mcPath : null;
        } 

        public string[] GetVersionPaths(ref string mcPath)
        {
            return Directory.GetDirectories(mcPath + @"\versions");
        }

        public List<Installation> LoadInstallations(string[] versionsPaths)
        {
            List<Installation> installations = new List<Installation>();
            foreach (string path in versionsPaths)
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    if (file.Contains(".json") && IsValidInstallation(path)) installations.Add(CreateFromJson(file));
                }
            }
            return installations;
        }

        public bool IsValidInstallation(string path)
        {
            bool jar = false, json = false;
            foreach (string file in Directory.GetFiles(path))
            {
                if (file.Contains(".jar")) jar = true;
                else if (file.Contains(".json")) json = true;
            }
            return jar && json;
        }

        public Installation CreateFromJson(string path)
        {
            JObject json = JObject.Parse(File.ReadAllText(path));
            if (!json.ContainsKey("id")) return new VanillaInstallation("no_data", path, "no_version");
            string name = json.GetValue("id").ToString();
            InstallationType type = name.Contains("forge") ? InstallationType.FORGE : name.Contains("fabric") ? InstallationType.FABRIC : InstallationType.OTHER;
            string modLoaderVersion = type == InstallationType.FORGE || type == InstallationType.FABRIC ? GetModLoaderVersion(name) : null;
            switch (type)
            {
                case InstallationType.FORGE:
                    return new ForgeInstallation(name, path, modLoaderVersion);
                case InstallationType.FABRIC:
                    return new FabricInstallation(name, path, modLoaderVersion);
                default:
                    return new OtherInstallation(name, path);
            }
        }

        public string GetModLoaderVersion(string id)
        {
            return id.Split('-')[2];
        }
    }
}
