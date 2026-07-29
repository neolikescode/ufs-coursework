using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many modules are you registered for this semester? ");
            int numregistered = int.Parse(Console.ReadLine());

            string[] modules = new string[numregistered];

            for (int i = 0; i < modules.Length; i++)
            {
                Console.Write($"Enter the name of module {i + 1}: ");
                string moduleName = Console.ReadLine();
                modules[i] = moduleName;
            }
            Console.WriteLine();
            Console.WriteLine("=== Your Registered Modules ===");

            foreach (string module in modules)
            {
                Console.WriteLine($"- {module}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total modules registered: {numregistered}");
        }
    }
}
