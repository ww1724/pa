using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.ICommon
{
    public interface IPluginManager
    {
        public void AddPluginPaths(string[] path);

        public void LoadPlugins();

        public void LoadPlugins(string path);

        public void UnloadPlugins();

        public void ReloadPlugins();

        public void LoadPlugin(string pluginName);

        public void UnloadPlugin(string pluginName);

        public void ReloadPlugin(string pluginName);

        public void InitializePlugins();

        public void InitializePlugin(string pluginName);

        public void DeinitializePlugins();

        public void DeinitializePlugin(string pluginName);

        public void StopPlugins();

        public void StopPlugin(string pluginName);
    }
}
