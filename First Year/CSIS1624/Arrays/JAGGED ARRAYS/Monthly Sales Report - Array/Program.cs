using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_Sales_Report___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jagged array stores all the sales
            double[][] sales = new double[3][];
            //Compile time initialization
            sales[0] = new double[3] { 5000, 7000, 6000 };
            sales[1] = new double[5] { 3000, 4000, 3500, 4500, 6000 };
            sales[2] = new double[2] { 8000, 9000 };

            double highestTotalSales = 0;
            int employeeNumber = 0;
            //Display Title
            Console.WriteLine("=========== SALES REPORT ==========\n");

            //Display the employee sales and calculate the total sales of each employee
            for (int employee = 0; employee < sales.Length; employee++)
            {
                double total = 0;
                Console.WriteLine($"Employee {employee + 1}:");
                for (int sale = 0; sale < sales[employee].Length; sale++)
                {
                    Console.WriteLine($"Day {sale + 1}: {sales[employee][sale]:C0}");
                    total += sales[employee][sale];
                }
                //Finds the highest total, and stores it
                if (total > highestTotalSales)
                {
                    highestTotalSales = total;
                    employeeNumber = employee;

                }
                //Display the total sales of each employee
                Console.WriteLine($"Total: {total:C0} \n\n");
               
            }
            //Display the number of the employee with the highest sales 
            Console.WriteLine("FLOWERS TO WHOM FLOWERS ARE OWED\n\nHighest sales employee:");
            Console.WriteLine($"Employee {employeeNumber + 1}\nTotal: {highestTotalSales:C0}");
        }
    }
}
