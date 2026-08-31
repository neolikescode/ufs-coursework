using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Manager__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Module Tracker ====\n");   
            List<string> modules = new List<string>();
            modules.Add("CSIS1624");
            modules.Add("CSIS1724");
            modules.Add("CSIS1824");
            modules.Add("CSIS1924");
            modules.Add("CSIS2024");

            for(int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"Index {i} - {modules[i]}");
            }
            Console.WriteLine();
            
            bool isValidIndex = false;

            while(!isValidIndex)
            {
                Console.Write("Enter the index of the module to remove: ");
                string index = Console.ReadLine();

                if(!string.IsNullOrWhiteSpace(index) && int.TryParse(index, out int result) && result >= 0 && result < modules.Count)
                {
                    isValidIndex = true;
                    modules.RemoveAt(result);
                }
                else
                {
                    Console.WriteLine("Enter a valid index of the module to remove ");
                }
            }

            bool isValidInsert = false;

            while (!isValidInsert)
            {
                Console.Write("Enter a new module to insert: ");
                string insertMod = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(insertMod) && !modules.Contains(insertMod))
                {
                    bool isValidNum = false;

                    while (!isValidNum)
                    {
                        Console.Write("Where should it be inserted? ");
                        string insertionPt = Console.ReadLine();

                        if(!string.IsNullOrWhiteSpace(insertionPt) && int.TryParse(insertionPt, out int insertHere) && insertHere >= 0 && insertHere <= modules.Count)
                        {
                            modules.Insert(insertHere, insertMod);
                            isValidNum = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid insertion point ");
                        }
                    }
                    isValidInsert = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid module Name ");
                }
            }
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("==== Results ====");

            for(int j = 0; j < modules.Count; j++)
            {
                Console.WriteLine(modules[j]);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
