using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displays Title
            Console.WriteLine("========== Classroom Marks Table==========");
            Console.WriteLine();
            //Rectangular integer array stores the 4 scores of each student in a row X col format 
            double[,] marks =
            {
                {75, 80, 90},
                {60, 70, 65},
                {88, 92, 85},
                {55, 60, 58}
            };
            //Variable that will store the averge mark for each learner
            double average;
            
            //Nested For loop loops through each row, and displays all the student's marks (columns)
            for (int row = 0; row < marks.GetLength(0); row++)

            {
                //Variable that will store the total mark for each learner
                double totalMarks = 0;

                //Displays the all the 4 marks for each student
                Console.Write($"Student {row + 1}:\n ");
                
                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.Write($"{marks[row,col]} ");
                    totalMarks += marks[row, col];
                }
                //Calculates and stores the average mark for each learner
                average = totalMarks / marks.GetLength(1);
                Console.WriteLine();

                //Displays the average for each student
                Console.WriteLine($"\naverage: {average:F2}\n");
            }
           
        }
    }
}
