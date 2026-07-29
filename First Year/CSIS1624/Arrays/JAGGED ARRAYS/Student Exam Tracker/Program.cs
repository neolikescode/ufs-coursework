using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Student_Exam_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display Title and prompt user to enter the number of students
            Console.Write("========== Welcome To The Student Exam Tracker ==========\n\nHow many students? ");
            int numOfStudents = int.Parse(Console.ReadLine());
            //stores the marks of each student
            int[][] marks = new int[numOfStudents][];
            double average = 0;
          
            double highestAverage = 0;
            int highestStudent = 0;

            //Loops through initial array, and prompts user to enter number of tests taken by each student
            for (int row = 0; row < marks.Length; row++)
            {
                Console.Write($"\nHow many tests did student {row + 1} write? ");
                int numOfTests = int.Parse(Console.ReadLine());
                marks[row] = new int[numOfTests];
            }
            Console.WriteLine();

            //Gets the actual values of tests
            for (int row = 0; row < marks.Length; row++)
            {
                double total = 0;
                for (int col = 0; col < marks[row].Length; col++)
                {
                    Console.Write($"\nEnter Student {row + 1} Test {col + 1} mark: ");
                    marks[row][col] = int.Parse(Console.ReadLine());
                    total += marks[row][col];
                }
                Console.WriteLine();
               
                //Calculates the each students average
                average = total / marks[row].Length;
                
                if (average > highestAverage )
                {
                    highestAverage = average;
                    highestStudent = row;
                }
            }
            //Displays Report
            Console.WriteLine("\n========== Student Marks =========\n\n");
            for (int row = 0; row < marks.Length; row++)
            {
                double total = 0;
                Console.Write($"Student {row + 1}:\n");

                for (int col = 0; col < marks[row].Length; col++)
                {
                    Console.Write($"{marks[row][col]}\t");
                    total += marks[row][col];
                }
                average = total / marks[row].Length;
                Console.WriteLine($"\nAverage: {average:F2}\n\n\n");
            }

            Console.WriteLine("========== Highest Average ==========\n\n");
            Console.WriteLine($"Student {highestStudent + 1}");
            Console.WriteLine($"\nAverage {highestAverage:F2}\n\n\n");
        }
    
    }
}
