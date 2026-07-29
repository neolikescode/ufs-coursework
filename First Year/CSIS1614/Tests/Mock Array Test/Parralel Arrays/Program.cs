using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parralel_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = 
                {
                    "John Heller",
                    "Sam Kell",
                    "Keaton Rock",
                    "Timothy Asyra",
                    "Reginald Kingsley",
                };

            string[] locations =
                {
                    "Bloemfontein",
                    "Cape Town",
                    "Polokwane",
                    "Durban",
                    "Pretoria"
                };
            int[] ages =
                {
                    20, 30, 40, 50, 55
                }
                ;

            string[] profession =
                {
                    "Junior Software Engineer",
                    "Software Dev",
                    "IT Specialist",
                    "Senior Software Engineer",
                    "Project Lead"
                };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} is {ages[i]} years old, their profession is: {profession[i]} at {locations[i]}\n");
            }
            Console.WriteLine();
            Get2DArray();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
           

        }
        private static void Get2DArray()
        {
            int[,] numbers =
               {
                    { 1, 2, 3},
                    { 4, 5, 6},
                    { 7, 8, 9}
               };

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write($"{numbers[row, col]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
