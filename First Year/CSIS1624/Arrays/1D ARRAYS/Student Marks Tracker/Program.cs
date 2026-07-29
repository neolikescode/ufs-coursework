using System;
namespace Student_Marks_Tracker___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declared a string array to store the names of the students
            string[] studentNames =
                {
                    "John Smith",
                    "Sara Jones",
                    "Mike Brown",
                    "Amy White"
                };

            //Declared a 'double' array to store the student marks
            double[] studentMarks =
                {
                    78,
                    65,
                    91,
                    54
                };
            //Declared a double variable to store the total score of all the students
            double dTotal = 0;

            //Declared variables that will store the Highest value and name of student with said highest value
            double dHighest = studentMarks[0];
            string sHighest = studentNames[0];

            /*For loop, will loop into the arrays and display each value stored by the arrays
              since they share the same index*/
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine($"{ studentNames[i]} received {studentMarks[i]}%\n");

                //dTotal will be used to store each mark that is looped through
                dTotal += studentMarks[i];

                //if statement will determine the highest mark and then the variable sHighest stores the said student's name
                if (studentMarks[i] > dHighest)
                {
                    dHighest = studentMarks[i];
                    sHighest = studentNames[i];
                }
            }
            //dClassAverage variable will store the Average of the whole class
            double dClassAverage = dTotal/studentMarks.Length;
            //Display the results
            Console.WriteLine("========== RESULTS ==========");
            Console.WriteLine($"\nCongratulations, The Class Average Is: {dClassAverage:F2}%");
            Console.WriteLine($"\nThe student with the Highest mark is: {sHighest}");
        }
    }
}
