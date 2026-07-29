using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiates the Jagged Array, to store 3 arrays with different indexes/number of subjects
            string[][] subjects =
            {
                new string[] {"Mathematics","Physics","Computer Science"},
                new string[] {"Mathematics", "English"},
                new string[] {"Mathematics", "Physics","Chemistry","Biology", "Computer Science" }
            };
            //Displays Title
            Console.WriteLine("========== STUDENT SUBJECTS ==========\n");

            //Nested loop, Loops through the Jagged Array in order to display its values
            for (int student = 0; student < subjects.Length; student++)
            {
                Console.WriteLine($"Student {student + 1}");
                for (int subject = 0; subject < subjects[student].Length; subject++)
                {
                    Console.WriteLine($"{subjects[student][subject]}");
                }
                Console.WriteLine();
            }

        }
    }
}
