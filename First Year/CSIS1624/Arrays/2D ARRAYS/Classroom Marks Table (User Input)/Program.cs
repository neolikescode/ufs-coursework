using System;

namespace Rectangular_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displays Title
            Console.WriteLine("========== Classroom Marks Table==========");

            //Get users input to determine the size (rows and columns) of the array
            Console.Write("\nEnter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter number of marks: ");
            int numOfTests = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Rectangular integer array stores the scores of each student in a row X col format 
            int[,] marks = new int[numOfStudents, numOfTests];

            //Variables that will store the averge mark for each learner and the total mark
            double average;
            

            //Nested For loop which will get users input to store in the array at the given index
            for (int row = 0; row < marks.GetLength(0); row++)
            {
                
                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.Write($"Student {row + 1} Test {col + 1}: ");
                    marks[row, col] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //Nested For loop loops through each row, and displays all the student's marks (columns)
            for (int row = 0; row < marks.GetLength(0); row++)
            {
                double totalTestMarks = 0;
                Console.WriteLine($"Student {row + 1}: \nMarks: ");

                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.Write($"{marks[row, col]} ");
                    totalTestMarks += marks[row, col];

                }
                //Calculates the average and displays it
                average = totalTestMarks / marks.GetLength(1);
                Console.WriteLine();
                Console.WriteLine($"\nAverage: {average:F2}\n");
            }

        }
    }
}
