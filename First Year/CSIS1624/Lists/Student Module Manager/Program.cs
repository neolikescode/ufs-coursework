using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Module_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> modules = new List<string>();
            Console.WriteLine("=== Student Module Tracker ===");
            
            bool isValidNum = false;

            while (!isValidNum)
            {
                Console.Write("How many modules do you want to enter? ");

                string numberOfModules = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(numberOfModules) && int.TryParse(numberOfModules, out int moduleNum))
                {
                    Console.WriteLine();
                    for (int i = 0; i < moduleNum; i++)
                    {
                        bool isValidMod = false;
                        while (!isValidMod)
                        {
                            Console.Write($"Enter module {i + 1}: ");
                            string mod = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(mod) && !modules.Contains(mod))
                            {
                                modules.Add(mod);
                                isValidMod = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid module Name ");
                            }
                        }
                    }
                    isValidNum = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number ");
                }
            }

            bool isValidName = false;
            while (!isValidName)
            {
                Console.WriteLine();
                Console.Write("Enter module to remove: ");
                string removeMod = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(removeMod) && modules.Contains(removeMod))
                {
                    modules.Remove(removeMod);
                    Console.Write("Module successfully removed ");
                    isValidName = true;
                }
                else
                {
                    Console.WriteLine("Module not found ");
                }
            }

            Console.WriteLine("=== Modules ===");
           for(int j = 0; j < modules.Count; j++)
            {
                Console.WriteLine(modules[j]);
            }
        }
    }
}
