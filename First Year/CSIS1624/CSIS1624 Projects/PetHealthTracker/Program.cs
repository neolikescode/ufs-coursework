/* Neo Kgatla
 * 2029139488
 * Practical 7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an array of type Pet that will store each instance of the Pet class
            Pet[] pets = new Pet[5];

            // iterate through the array and prompt the user for the necessary details of each pet.
            for (int i = 0; i < pets.Length; i++)
            {
                //Clears the console before getting the details for each new pet
                Console.Clear();

                //Instantiates a new object of the class Pet
                pets[i] = new Pet();

                Console.WriteLine($"Enter details for Pet {i + 1}:");
                //Gets the Pets details and stores them in the apropriate property
                Console.Write("Name: ");
                pets[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                pets[i].Age = int.Parse(Console.ReadLine());

                Console.Write("Weight (kg): ");
                pets[i].Weight = double.Parse(Console.ReadLine());
            }
            //Clears the console before continuing with the program.
            Console.Clear();
            double dTotalWeight = 0;
            Console.WriteLine("Pet Details: \n");

            // foreach loop displays the details of each of the pets stored in the pets array
            foreach (Pet p in pets)
            {
                Console.WriteLine(new string('-', 30));
                p.DisplayPetInfo();
                //Stores the total weight of all the pets combined
                dTotalWeight += p.Weight;
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', 30));

            //Calculates the average weight of all the pets
            double dAverage = dTotalWeight/pets.Length;

            //Displays the average weight of all the pets
            Console.WriteLine($"Average Weight: {dAverage:F1} Kg");
            Console.WriteLine(new string('=', 30));

            //Inform the user how to exit the console window
            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
