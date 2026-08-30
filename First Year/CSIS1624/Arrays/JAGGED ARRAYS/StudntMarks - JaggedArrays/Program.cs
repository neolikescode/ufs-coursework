using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudntMarks___JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidNumOfStds = false;
            while (!isValidNumOfStds)
            {
                Console.WriteLine("===== Student Marks Tracker =====");
                Console.Write("How many students? ");
                string numofstd = Console.ReadLine();
                
                if (int.TryParse(numofstd, out int result) && result > 0 && result < 50)
                {
                    int[][] marks = new int[result][];

                    for (int row = 0; row < marks.Length; row++)
                    {
                        bool isValidNumOfTests = false;
                        while (!isValidNumOfTests)
                        {
                            Console.Write($"How many tests will you enter for Student {row + 1}? ");
                            string testNum = Console.ReadLine();

                            if (int.TryParse(testNum, out int numOfTests) && numOfTests > 0 && numOfTests <= 10)
                            {
                                marks[row] = new int[numOfTests];
                                isValidNumOfTests = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number between 1-10");
                                isValidNumOfTests = false;
                            }
                        }
                    }
                    Console.WriteLine();
                    for (int row = 0; row < marks.Length; row++)
                    {
                        for (int col = 0; col < marks[row].Length; col++)
                        {
                            bool isValidTestMark = false;
                            while (!isValidTestMark)
                            {
                                Console.Write($"Enter Student {row + 1}'s test {col + 1} mark: ");
                                string testMark = Console.ReadLine();
                                if (int.TryParse(testMark, out int answer) && answer >= 0 && answer <= 100)
                                {
                                    marks[row][col] = answer;
                                    isValidTestMark = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number between 0-100");
                                    isValidTestMark = false;
                                }
                            }
                        }
                    }

                    Console.WriteLine("\n========== Results =========\n\n");
                    for (int row = 0; row < marks.Length; row++)
                    {
                        Console.Write($"Student {row + 1}:\n");

                        for (int col = 0; col < marks[row].Length; col++)
                        {
                            Console.Write($"{marks[row][col]} ");
                        }
                        Console.WriteLine();
                    }
                    isValidNumOfStds = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1-50");
                    isValidNumOfStds = false;
                }
            }
        }
    } 
}
