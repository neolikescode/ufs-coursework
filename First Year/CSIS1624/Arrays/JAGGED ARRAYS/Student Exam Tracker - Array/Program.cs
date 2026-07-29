using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Exam_Tracker___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students? ");
            int numOfStudents = int.Parse(Console.ReadLine());

            int[][] marks = new int[numOfStudents][]; 

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.Write($"Student {i + 1} tests: ");
                int test = int.Parse(Console.ReadLine());
                marks[i] = marks[i][test];
            }
        }
    }
}
