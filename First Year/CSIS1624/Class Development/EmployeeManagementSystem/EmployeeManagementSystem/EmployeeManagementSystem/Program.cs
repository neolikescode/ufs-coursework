using System;

namespace EmployeeManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee Worker = new FullTimeEmployee("John", "Doe", "jdog@yahoo.com", "27738941023", 20300);
            Console.WriteLine($"Employee ID: {Worker.EmployeeID}\n{Worker.DisplayInformation()}\n");

            Worker = new PartTimeEmployee("Kgotso", "Dube", "kg.dubs@example.com", "0872301023", 20.5 , 485);
            Console.WriteLine($"Employee ID: {Worker.EmployeeID}\n{Worker.DisplayInformation()}\n");

            Worker = new Contractor("Kay", "Lands", "lands.k@example.com", "0714561234", 3, 4000);
            Console.WriteLine($"Employee ID: {Worker.EmployeeID}\n{Worker.DisplayInformation()}\n");

            Console.Write("\n\nPress any key to exit . . . ");
            Console.ReadKey();
        }
    }
}
