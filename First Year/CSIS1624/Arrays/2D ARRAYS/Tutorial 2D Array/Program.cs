using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to enter row and column and store the users values into variables
            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the number of the columns: ");
            int columns = int.Parse(Console.ReadLine());
            //Declare array that will store values entered by user, below
            int[,] numbers = new int[rows, columns];

            //Prompts user to enter values to stor in the array
            Console.WriteLine($"\nEnter the cells of the matrix: \n");

            //Allows user to enter value, that are then stored in the array
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write($"Matrix[{row},{col}] = ");
                    int matrix = int.Parse(Console.ReadLine());
                    numbers[row, col] = matrix;
                }
            }
            Console.WriteLine();
            //Prints the users values in appropriate order 
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
