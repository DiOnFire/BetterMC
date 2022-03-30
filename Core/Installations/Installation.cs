using BetterMC.Core.Exception;
using System.IO;

namespace BetterMC.Core.Installations
{
    public sealed class Installation
    {
        private string name, path, loaderVersion;
        private InstallationType type;

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Trim().Equals("")) name = value.Trim();
                else throw new InvalidNameException("Name cannot be empty.");
            }
        }

        public string Path
        {
            get { return path; }
            set
            {
                if (File.Exists(value)) path = value;
                else throw new FileNotFoundException();
            }
        }

        public string LoaderVersion
        {
            get { return loaderVersion; }
            set
            {
                if (this.type == InstallationType.VANILLA) throw new InvalidInstallationTypeException("Vanilla version cannot have a mod loader version!");
                else loaderVersion = value;
            }
        }

        public InstallationType Type
        {
            get { return type; }
        }

        public Installation(string name, InstallationType type, string path)
        {
            this.Name = name;
            this.type = type;
            this.Path = path;
        }

        public Installation(string name, InstallationType type, string loaderVersion, string path)
        {
            this.Name = name;
            this.type = type;
            this.LoaderVersion = loaderVersion;
            this.Path = path;
        }

        public bool IsExist()
        {
            return File.Exists(Path);
        }

        public void Launch()
        {

        }

        public void Delete()
        {

        }
    }
}
