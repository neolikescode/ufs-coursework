/* 2029139488
 * Neo Kgatla
 * 08/06/2026
 * Semester Test 2
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Test_2_2026
{
    internal class Program
    {
        //MAIN METHOD STARTS
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Monthly Expense Tracker!");
            Console.WriteLine();
            Console.Write("How many expense categories do you wish to process? ");
            int iCategories = int.Parse(Console.ReadLine());
            Console.WriteLine();

            decimal[] amounts = new decimal[iCategories];
            string[] names = new string[iCategories];

            for (int i = 0; i < amounts.Length; i++)
            {
                Console.WriteLine($"--- Category {i+1} ---");
                GetExpenseDetails(i, names, amounts);
            }

            DisplayReport(iCategories, names, amounts);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
        
        private static void GetExpenseDetails(int i, string[] names, decimal[] amounts)
        {
            Console.Write("Enter expense category: ");
            string sExpense = Console.ReadLine();

            Console.Write("Enter amount spent: R");
            string sAmount = Console.ReadLine();
         
            try
            {
                decimal dAmount = decimal.Parse(sAmount);
                
                if (dAmount < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Amount entered is negative. Recorded as 0.");
                    dAmount = 0;
                    names[i] = sExpense;
                    amounts[i] = dAmount;
                }
                else
                {
                    names[i] = sExpense;
                    amounts[i] = dAmount;
                    Console.WriteLine();
                }
            }
            catch
            {
                names[i] = sExpense;
                amounts[i] = 0;
                Console.WriteLine(); 
                Console.WriteLine("Invalid amount entered. Recorded as 0.");
                Console.WriteLine();
            }

        }

        private static void DisplayReport(int iCategories, string[] names, decimal[] amounts)
        {
            decimal dTotal = 0;
            Console.WriteLine("================ MONTHLY EXPENSE REPORT ================");
            for (int i = 0; i < amounts.Length; i++)
            {
                dTotal += amounts[i];
                Console.WriteLine($"{names[i], -15}: {amounts[i]:C2}");
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Total Monthly Expenses : {dTotal:C2}");
            if (dTotal > 15000)
            {
                Console.WriteLine("Warning: High spending this month! Please review your expenses.");
            }
            else if (dTotal > 8000)
            {
                Console.WriteLine("Moderate spending detected.");
            }
            else
            {
                Console.WriteLine("Good expense control! Keep it up.");
            }
        }


    }
}
