/* 2029139488
 * NEO KGATLA
 * 16/05/2026
 * SEMESTER TEST 2  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Test_2___2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sMsg = "";
            string sName;
            decimal mPrice = 0m;
            decimal mTotal = 0m;
            bool isValid = true;
            while (IsAnother())
            {
                sName = GetItemName();
                mPrice = GetItemPrice("Enter price for " + sName + ": ", ref isValid);
                if (isValid)
                {
                    mTotal += mPrice;
                    sMsg += sName + "\t\t\t" + mPrice.ToString() + "\n";
                }
            }
            DisplayBill(sMsg, mTotal);
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
        private static bool IsAnother()
        {
            Console.Write("Another one ('Y/N')? ");
            string sAns = (Console.ReadLine());
            //bool bResponse = true;

            if (sAns == "y" || sAns == "Y")
            {
                //return bResponse;
                return true;
            }
            //else
            //{
            //    bResponse = false;
            //}

            return false;
        }
        private static string GetItemName()
        {
            Console.Write("Enter the name of next item: ");
            string sItem = Console.ReadLine();
            return sItem;
        }
        private static decimal GetItemPrice(string sItemPrice, ref bool isValid)
        {
            Console.Write($"{sItemPrice}");
            string sResponse = Console.ReadLine();
            decimal dItemPrice;

            if (decimal.TryParse(sResponse, out dItemPrice) && dItemPrice >= 0)
            {
                isValid = true;
                return dItemPrice;
            }
            else 
            {
                isValid = false;
                Console.WriteLine("Invalid price");
                return 0;
            }

        }
        private static void DisplayBill(string sMsg, decimal mTotal)
        {
            Console.WriteLine();
            Console.WriteLine($"{sMsg}\n\t\t\t--------");
            Console.WriteLine($"Total\t\t\t{mTotal}\n\t\t\t========");
        }
    }
}
