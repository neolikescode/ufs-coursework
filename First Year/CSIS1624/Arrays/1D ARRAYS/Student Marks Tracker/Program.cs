using System;
namespace Student_Marks_Tracker___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---===  Student Grade Tracker  ===---\n");

            Console.Write("How many students do you want to grade: ");
            string students = Console.ReadLine();

            Console.WriteLine();

            int[] marks;

            int distinctions = 0;

            int fails = 0;

            if (int.TryParse(students, out int numOfStudents) && numOfStudents > 0)
            {
                marks = new int[numOfStudents];
                bool isValid;

                for (int i = 0; i < marks.Length; i++)
                {
                    do
                    {
                        isValid = true;
                        Console.Write($"Input grade for Student {i + 1}: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
                        {
                            marks[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a value between 0 and 100.");
                            isValid = false;
                        }
                    }
                    while (!isValid);
                    
                }
                Console.Clear();
                Console.WriteLine("---===  Student Grade Tracker  ===---\n\nGrades entered");
                foreach (int mark in marks)
                {
                        if (mark >= 75)
                        {
                            distinctions++;
                        }
                        else if (mark < 50)
                        {
                            fails++;
                        }
                    Console.Write($"{mark}%\t");
                }
                Console.WriteLine();
                Console.WriteLine($"\nThe number of Distinctions (>= 75%) found was : {distinctions}");
                Console.WriteLine($"The number of Failures (< 50%) found was : {fails}");
                Console.WriteLine();
                Console.WriteLine($"\nPress any key to exit...");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }
            Console.ReadKey();
        }
    }
}
