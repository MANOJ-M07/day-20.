using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ConRef3.Interface;

namespace ConRef3
{
    public class PluginManager
    {
        List<IPlugin> plugins;

        public PluginManager()
        {
            plugins = new List<IPlugin>();
        }

        public void LoadPlugins(string pluginDirectory = null)
        {
            string path = pluginDirectory ?? AppDomain.CurrentDomain.BaseDirectory;
            var pluginFiles = Directory.GetFiles(path, ".dll");
            foreach (var file in pluginFiles)
            {
                Assembly assembly = Assembly.LoadFrom(file);
                var plugiTypes = assembly.GetTypes().Where(type => typeof(IPlugin).IsAssignableFrom(type));
                foreach (var plugiType in plugiTypes)
                {
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(plugiType);
                    plugins.Add(plugin);
                }
            }
        }
        public void ExecutePlugins()
        {
            Console.WriteLine("Executing Plugins");
            foreach (var plugin in plugins)
            {
                plugin.Execute();
            }
        }
    }
}
