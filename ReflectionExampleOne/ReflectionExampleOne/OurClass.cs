using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExampleOne
{
    public class OurClass
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to OurClass");
        }

        public void SecondMethod()
        {
            Console.WriteLine("Second Method");
        }

        private int num;
        public int Num
        {
            get { return Num; }
            set { Num = value; }
        }
        private string name;
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
