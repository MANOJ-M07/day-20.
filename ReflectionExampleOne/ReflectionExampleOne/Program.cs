using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExampleOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(OurClass);
            PropertyInfo[] properties = type.GetProperties();
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine("properties in our class");
            foreach (var prop in properties)
            {
                Console.WriteLine("Property : " + prop.Name);
            }
            Console.WriteLine("Methods in OurClass");
            foreach (var method in methodInfos)
            {
                Console.WriteLine("Methods: " + method.Name);
            }
            Console.ReadKey();
        }
    }
}
