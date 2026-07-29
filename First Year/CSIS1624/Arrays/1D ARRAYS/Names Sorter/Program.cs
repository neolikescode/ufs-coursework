using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts the user to enter the array size which is determined by the number of names the user wants to enter
            Console.Write("Enter the number of names: ");
            int noOfNames = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Holds the names entered by the user
            string[] lastNames = new string [ noOfNames ];

            //Allows user to enter names
            for(int i = 0; i < lastNames.Length; i++)
            {
                Console.Write("Enter name (Last name first): ");
                lastNames[i] = Console.ReadLine();
                Console.WriteLine();
            }
            //Remove the above from the console
            Console.Clear();
            Array.Sort(lastNames);

            //Displays the names in alphabetical order
            for (int i = 0; i < lastNames.Length; i++)
            {
                Console.WriteLine(lastNames[i]);
            }
        }
    }
}
