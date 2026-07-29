/* 2029139488
 * Neo Kgatla 
 * 08 / 06 / 2026 
 * Practical 5 (Mock Test) 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Test_Prac_5_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string sName = Console.ReadLine();

            Console.Write("Street Address: ");
            string sStreetAddress = Console.ReadLine();

            Console.Write("City: ");
            string sCity = Console.ReadLine();

            Console.Write("Province: ");
            string sProvince = Console.ReadLine();

            Console.Write("Postal Code: ");
            string sPostalCode = Console.ReadLine();

            Console.Write("How many hoodies would you like? ");
            int iHoodieNum = int.Parse(Console.ReadLine());

            const decimal dTaxPercent = 0.07m;
            const decimal dHoodiePrice = 99.95m;

            decimal dSum = iHoodieNum * dHoodiePrice;

            decimal dTax = dSum * dTaxPercent;

            decimal dTotal = dSum + dTax;

            char cDiscount;

            decimal dTotalAmount = 0m;

            string sDiscountPercentage;
            decimal dDiscPercent;

            if (dTotal > 1000)
            {
                cDiscount = 'A';
                dDiscPercent = dTotal * 0.15m;
                dTotalAmount = dTotal - dDiscPercent;

            }
            else if (dTotal > 500 && dTotal <= 1000)
            {
                cDiscount = 'B';
                dDiscPercent = dTotal * 0.10m;
                dTotalAmount = dTotal - dDiscPercent;
            }
            else
            {
                cDiscount = 'C';
                dTotalAmount = dTotal;
            }

            Console.WriteLine("---------------------------------------------------------\nReceipt for: ");
            switch (cDiscount)
            {
                case 'A':
                    sDiscountPercentage = "15%";
                    Console.WriteLine($"{sName}\n{sStreetAddress}\n{sCity}\n{sProvince}\n{sPostalCode}");
                    Console.WriteLine($"{iHoodieNum} hoodies ordered @ {dHoodiePrice:C2} each. ");
                    Console.WriteLine($"Total:{dSum,17:C2}\nTax:{dTax,18:C2}\nDiscount{sDiscountPercentage,11}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Due:{dTotalAmount,19:C2}");
                    Console.WriteLine("---------------------------------------------------------\n");
                    break;
                case 'B':
                    sDiscountPercentage = "10%";
                    Console.WriteLine($"{sName}\n{sStreetAddress}\n{sCity}\n{sProvince}\n{sPostalCode}");
                    Console.WriteLine($"{iHoodieNum} hoodies ordered @ {dHoodiePrice:C2} each. ");
                    Console.WriteLine($"Total:{dSum,17:C2}\nTax:{dTax,18:C2}\nDiscount{sDiscountPercentage,11}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Due:{dTotalAmount,19:C2}");
                    Console.WriteLine("---------------------------------------------------------\n");
                    break;
                case 'C':
                    
                    Console.WriteLine($"{sName}\n{sStreetAddress}\n{sCity}\n{sProvince}\n{sPostalCode}");
                    Console.WriteLine($"{iHoodieNum} hoodies ordered @ {dHoodiePrice:C2} each. ");
                    Console.WriteLine($"Total:{dSum,17:C2}\nTax:{dTax,18:C2}\nNo Discount.");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Due:{dTotalAmount,19:C2}");
                    Console.WriteLine("---------------------------------------------------------\n");
                    break;

                default:
                    Console.WriteLine("Invalid entry.");
                    break;
            }

            //Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
