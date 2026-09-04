using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Menu_driven_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> modules = new List<string>();

            bool isValid = false;

            while (!isValid)
            {
                int choice = DisplayMenu(); ;

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        {
                            AddModules(modules);
                            break;
                        }
                    case 2:
                        {
                            RemoveModules(modules);
                            break;
                        }
                    case 3:
                        {
                            DisplayModules(modules);
                            break;
                        }
                    case 4:
                        {
                            ClearModules(modules);
                            break;
                        }
                    case 5:
                        {
                            isValid = true;
                            break;
                        }
                    default:
                        {
                            if (choice < 1 || choice > 5)
                            {
                                Console.WriteLine("Error has occured");
                            }
                            break;
                        }
                }
            }
        }
        static int DisplayMenu()
        {
            Console.WriteLine("===== MODULE MANAGER =====\n\n");
            Console.WriteLine("1. Add Module\n2. Remove Module\n3. Display Modules \n4. Clear Modules \n5. Exit\n\n");
            Console.Write("Enter Choice: ");
            string userChoice = Console.ReadLine();

            bool isValidChoice = true;
            while (isValidChoice)
            {
                if (!string.IsNullOrWhiteSpace(userChoice) && int.TryParse(userChoice, out int iUserChoice) && iUserChoice > 0 && iUserChoice <= 5)
                {
                    isValidChoice = false;
                    return iUserChoice;
                }
                else
                {
                    Console.WriteLine("Please enter a correct value \n");
                    return 0;
                }
            }
            return 0;

        }
        static void AddModules(List<string> modules)
        {
            bool isValidMod = false;
            while (!isValidMod)
            {
                Console.Write("Enter the module name: ");
                string modName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(modName) && !modules.Contains(modName))
                {
                    modules.Add(modName);
                    isValidMod = true;
                    Console.Write("Module added successfully \n");
                }
                else
                {
                    Console.WriteLine("Please enter a valid module name\n");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void RemoveModules(List<string> modules)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (modules.Count != 0)
                {
                    bool isValidMod = false;
                    while (!isValidMod)
                    {
                        Console.WriteLine();
                        Console.Write("Enter the module name: ");
                        string modName = Console.ReadLine();

                        if (modules.Contains(modName))
                        {
                            modules.Remove(modName);
                            Console.Write("Module removed successfully ");
                            isValidMod = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid module name\n");
                        }
                        Console.WriteLine();

                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("List is Empty ");
                    isValid = true;
                }
                Console.WriteLine();
            }
        }
        static void DisplayModules(List<string> modules)
        {
            Console.WriteLine("===== Modules =====\n");
            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {modules[i]}");
            }
        }

        static void ClearModules(List<string> modules)
        {
            if (modules.Count != 0)
            {
                Console.WriteLine("Are you sure you want to clear everything? Y/N");

                string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    modules.Clear();
                    Console.Write("Modules cleared successfully ");
                }
                else
                {
                    Console.Write("Woah, Close Call ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            Console.WriteLine();
        }
    }

}