using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display Title, and get number of students 
            Console.Write("========== Welcome to the Student Registration Program ==========\n");
            Console.Write("How many students do you want to register? ");
            int numOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Store the names of students entered below
            List<string> students = new List<string>(); 

            //Get the name of the students
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.Write("Enter student name: ");
                students.Add(Console.ReadLine());
            }

            //Display the List
            Console.WriteLine("\n========== STUDENT LIST ==========\n\n");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i]}\n");
            }

            //Pompt user to enter a student they would like to search for
            Console.WriteLine("==================================");
            Console.Write("Enter a student to search: ");
            string search = Console.ReadLine();

            //if the student is present in the list, save the students position 
            int position = students.IndexOf(search);

            //Display message if student is found or not
            if (students.Contains(Console.ReadLine()))
            {
                Console.WriteLine();
                Console.WriteLine($"Student found at position {position + 1}\n");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Student not registered\n");
            }

            //Prompt the user to enter a name they would like to remove
            Console.Write("Enter a student name to remove: ");
            string removeName = Console.ReadLine();
            //Display appropriate message to the users entry
            if (students.Remove(removeName))
            {
                Console.WriteLine();
                Console.WriteLine("Student removed successfully\n");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Student does not exist\n");
            }

            //Display The Final List
            Console.WriteLine("========== Final Student List ==========\n");
            foreach( string student in students)
            {
                Console.WriteLine($"{student}\n");
            }
        } 
    
    }
}
