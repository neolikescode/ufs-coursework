using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and instantiate a string array to store the positions of the seats
            string[][] seats =
            {
                new string[5] {"A1","A2","A3","A4","A5"},
                new string[3] {"B1","B2","B3"},
                new string[4] {"C1","C2","C3","C4"}
            };
            //Display Title
            Console.WriteLine("========== CINEMA SEATS AVAILABLE ==========\n");
            
            bool found = false;
            //Nested for loop, will loop thru the array and display its values
            for (int row = 0; row < seats.Length; row++)
            {
                Console.WriteLine($"\nRow {row + 1}: ");
                for (int col = 0; col < seats[row].Length; col++)
                {
                    Console.Write($"{seats[row][col]} \t");
                }
                Console.WriteLine();
            }
            //Prompt user to enter seat they would like to find and store that value in a variable
            Console.Write("\nEnter a seat to search: ");
            string search = Console.ReadLine();

            //Nested loop traverses the array to look for the matching seat
            for (int row = 0; row < seats.Length; row++)
            {
                
                for (int col = 0; col < seats[row].Length; col++)
                {
                    //Print message to tell user if the seat is available or not
                    if (search == seats[row][col])
                    {
                        Console.WriteLine($"Seat Found:\nRow {row + 1}\nPosition {col + 1}");
                        found = true;
                        break;
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("Seat not found");
            }
        }
    }
}
