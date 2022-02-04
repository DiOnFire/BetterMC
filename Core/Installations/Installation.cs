using System.IO;

namespace BetterMC.Core.Installations
{
    abstract class Installation
    {
        public string name { get; set; }
        public string path { get; set; }
        public InstallationType type { get; }

        public Installation(string name, InstallationType type, string path)
        {
            this.name = name;
            this.type = type;
            this.path = path;
        }

        public bool IsExist()
        {
            return File.Exists(path);
        }

        public void Delete()
        {

        }
    }
}
