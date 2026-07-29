using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace fIddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get users array size and store it
            Console.Write("How many cities? ");
            int numberOfCities = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Arrays to store the users city name and temperature value
            string[] cities = new string[numberOfCities];
            double[] temperatures = new double[numberOfCities];

            //variable stores the total value of the temperatures entered by the user to calculate the average temperature
            double total = 0;

            //For loop will prompt the user to input values, and then save them at the current index i
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write("Enter the name of the city: ");
                cities[i] = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter the temperature of the city: ");
                temperatures[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            //Removes the above information from the console window
            Console.Clear();

            //For loop will display the city name and temperature
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"{cities[i],-15} {temperatures[i]:F1}");
                Console.WriteLine();
                total += temperatures[i];
            }

            //Calculates and displays the average temperature of the cities
            double average = total / cities.Length;
            Console.WriteLine($"Average temperature: {average:F1}\n");

            //Displays the names of the cities that are above the average temperature previously calculated
            Console.WriteLine("Above Average: ");
            for (int i = 0; i < cities.Length; i++)
            {
                //if statement filters out cities with temperatures below the average temperature calculated
                if (temperatures[i] > average)
                {
                    Console.WriteLine(cities[i]);
                    Console.WriteLine();
                }
            }
        }
    }

}


