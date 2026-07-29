using System;

namespace Rectangular_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display Title
            Console.WriteLine("========== Classroom Marks Table ==========");

            //Prompt user to get array size
            Console.Write("\nHow many students? ");
            int numOfStudents = int.Parse(Console.ReadLine());

            Console.Write("How many tests? ");
            int numOfTests = int.Parse(Console.ReadLine());

            //Int Array stores the users input values
            int[,] marks = new int[numOfStudents, numOfTests];

            // Nested For loop to prompt the user to Input marks
            for (int row = 0; row < marks.GetLength(0); row++)
            {
                Console.WriteLine($"\nEnter marks for Student {row + 1}");

                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.Write($"Test {col + 1}: ");
                    marks[row, col] = int.Parse(Console.ReadLine());
                }
            }

            // Initialise the variables using the first actual value entered
            int highestMark = marks[0, 0];
            int lowestMark = marks[0, 0];

            int highestStudent = 0;
            int highestTest = 0;

            int lowestStudent = 0;
            int lowestTest = 0;
            //Display marks table Title
            Console.WriteLine("\n========== MARKS TABLE ==========");

            // Display column headings
            Console.Write($"{"",-12}");

            for (int col = 0; col < marks.GetLength(1); col++)
            {
                Console.Write($"{"Test " + (col + 1),10}");
            }

            Console.WriteLine();

            // Nested For loop, to traverse the array and display its values
            for (int row = 0; row < marks.GetLength(0); row++)
            {
                double totalMarks = 0;

                Console.Write($"{"Student " + (row + 1),-12}");

                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.Write($"{marks[row, col],10}");

                    totalMarks += marks[row, col];

                    if (marks[row, col] > highestMark)
                    {
                        highestMark = marks[row, col];
                        highestStudent = row;
                        highestTest = col;
                    }

                    if (marks[row, col] < lowestMark)
                    {
                        lowestMark = marks[row, col];
                        lowestStudent = row;
                        lowestTest = col;
                    }
                }
                //Calculate average mark for each student
                double average = totalMarks / marks.GetLength(1);
                //Display the average mark for each student
                Console.Write($"{"Average:",10}{average,10:F2}");

                Console.WriteLine();
            }
            //Display HIghest ad Lowest Value
            Console.WriteLine("========== HIGHEST MARK ==========");
            Console.WriteLine($"Highest mark: {highestMark}");
            Console.WriteLine($"Achieved by:");
            Console.WriteLine($"Student {highestStudent + 1}");
            Console.WriteLine($"Test {highestTest + 1}");

            Console.WriteLine("\n========== LOWEST MARK ==========");
            Console.WriteLine($"Lowest mark: {lowestMark}");
            Console.WriteLine($"Achieved by:");
            Console.WriteLine($"Student {lowestStudent + 1}");
            Console.WriteLine($"Test {lowestTest + 1}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}