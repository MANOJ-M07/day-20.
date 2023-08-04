using System;
using System.Reflection;

namespace CustomInfoAttribute
{//Task1 : Create a Custom Attribute
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]

    public class CustomInfoAttribute : Attribute
    {
        public string ClassName { get; }

        public int VersionNumber { get; }

        public string AdditionalInfo { get; }

        public CustomInfoAttribute(string className, int versionNumber, string additionalInfo)
        {
            ClassName = className;
            VersionNumber = versionNumber;
            AdditionalInfo = additionalInfo;
        }
    }

    //Task2: Reflection on custom Attribute
    [CustomInfo("MyClass", 1, "This is a custom attribute example.")]

    public class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Welcome to My Method");
        }
    }

    //Task3 : Dynamic Method Invocation

    public class Calculator
    {
        public int Add(int a, int b)
        { return a + b; }

        public int Subtract(int a, int b)
        { return a - b; }

        public int Multiply(int a, int b)
        { return a * b; }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            //Task 2: Reflection on custom Attribute
            Type myClassType = typeof(MyClass);
            var customAttribute = myClassType.GetCustomAttribute<CustomInfoAttribute>();

            Console.WriteLine("Task 2 : Reflection on custom Attribute");
            Console.WriteLine($"Class Name: {customAttribute.ClassName}");
            Console.WriteLine($"Version Number: {customAttribute.VersionNumber}");
            Console.WriteLine($"Additional Info: {customAttribute.AdditionalInfo} \n");

            //  Task3 : Dynamic Method Invocation

            var calculator = new Calculator();
            Console.WriteLine("Task3: Dynamic Method Invocation");
            Console.WriteLine("Available Methods Add, Subtract , Multiply");
            Console.WriteLine("Enter Method Name:");
            string methodName = Console.ReadLine();

            MethodInfo method = typeof(Calculator).GetMethod(methodName);
            if (method != null)
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());


                Console.Write("Enter Second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = (int)method.Invoke(calculator, new object[] { num1, num2 });
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid method name.");
            }

            Console.ReadKey();
        }
    }
}