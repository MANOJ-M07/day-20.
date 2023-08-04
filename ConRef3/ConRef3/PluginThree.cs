using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConRef3
{
    internal class PluginThree: IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin three  is executing .............");
        }
    }
}
