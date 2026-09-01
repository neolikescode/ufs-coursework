using System;
using System.Collections.Generic;

namespace Module_Creator___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> modules = GetModules();
            DisplayModules(modules);
        }
        private static List<string> GetModules()
        {
            List<string> modules = new List<string>();
            bool isValidNum = false;

            while (!isValidNum)
            {
                Console.Write("How many modules would you like to enter? ");
                string sNum = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(sNum) && int.TryParse(sNum, out int iNum) && iNum > 0 && iNum <= 50)
                {
                    for (int i = 0; i < iNum; i++)
                    {
                        bool isValidMod = false;
                        while (!isValidMod)
                        {
                            Console.Write("Enter the module name: ");
                            string modName = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(modName))
                            {
                                modules.Add(modName);
                                isValidMod = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid module name");
                            }
                        }
                    }
                    isValidNum = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Number ");
                }
            }
            return modules;
        }
        private static void DisplayModules(List<string> modules)
        {
            Console.WriteLine("===== Modules =====\n");
            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {modules[i]}");
            }
        }
    }
}
