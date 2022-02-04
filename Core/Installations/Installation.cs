using System.IO;

namespace BetterMC.Core.Installations
{
    abstract class Installation
    {
        private string name { get; set; }
        private string path { get; set; }
        private InstallationType type { get; }

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
