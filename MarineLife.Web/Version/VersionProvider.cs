using System.IO;
using Newtonsoft.Json;

namespace MarineLife.Web.Version
{
    public static class VersionProvider
    {
        private static MarineLife.Web.Version.Version _currentVersion = null;
        
        public static MarineLife.Web.Version.Version Current => GetVersion();

        private static MarineLife.Web.Version.Version GetVersion()
        {
            return _currentVersion ??= LoadFromFile();
        }

        private static MarineLife.Web.Version.Version LoadFromFile()
        {
            var codeBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var rootDir  = System.IO.Path.GetDirectoryName(codeBase);
            var path = Path.Join(rootDir, "version.json");
            var fullPath = Path.GetFullPath(path);
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<MarineLife.Web.Version.Version>(json);
        }
    }
}