using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConRef3
{
    internal class PluginTwo:Iplugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin two  is executing .............");
        }
    }
}
