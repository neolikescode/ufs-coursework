using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdntModules___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("=== Student Modules Tracker ===\n");

            List<string> modules = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                bool isValidName = false;

                while (!isValidName)
                {
                    Console.Write($"Enter module {i + 1}: ");
                    string mod = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(mod))
                    {
                        modules.Add(mod);
                        isValidName = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid module name");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===== Modules =====\n\n");
            for (int j = 0; j < modules.Count; j++)
            {
                Console.WriteLine($"{modules[j]}");
            }
        }
    }
}
