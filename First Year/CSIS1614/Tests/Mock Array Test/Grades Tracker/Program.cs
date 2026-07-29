/* 2029139488
 * Neo Kgatla
 * 20 July 2026
 * CSIS1624 Tutoral
 */
using System;

namespace Grades_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---=== Student Grade Tracker ===---\n\n");
            Console.Write("How many students do you want to grade: ");
            bool isValid = true;
            int numOfStudents = 0;
            int[] grades 
            while (isValid)
            {
                try
                {
                    numOfStudents = int.Parse(Console.ReadLine());
                    isValid = false;
                    grades = new int [numOfStudents];
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                }

            }
           
            do
            {
                Console.Write($"Input grade for student {i + 1}: ");
                
                Console.WriteLine();
            }
            while()
            Console.WriteLine();
        }
    }
}
