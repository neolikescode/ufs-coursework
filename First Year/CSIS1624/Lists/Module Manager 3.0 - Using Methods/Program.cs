using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Manager_using_Methods__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> modules = new List<string>();

            AddModules(modules);

            DisplayModules(modules);

            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
        private static void AddModules(List<string> moduless)
        {
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
                                moduless.Add(modName);
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
        }
        private static void DisplayModules(List<string> moduless)
        {
            Console.WriteLine("===== Modules =====\n");
            for(int i = 0; i < moduless.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {moduless[i]}");
            }
        }
    }
}
