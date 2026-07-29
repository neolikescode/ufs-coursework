/* Neo Kgatla
 * 2029139488
 * 07/06/2026
 * Practical 9
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_9_Methods_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;
            Console.Write("Enter your starting balance: R");
            string startInput = Console.ReadLine();
            if (decimal.TryParse(startInput, out balance) && balance >= 0)
            {
                Console.WriteLine($"\nAccount created with balance: R{balance:F2}");
                string choice;
                do
                {
                    Console.WriteLine("\n===== Bank Account Menu =====");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter deposit amount: R");
                            string depositInput = Console.ReadLine();
                            Deposit(depositInput, ref balance);
                            break;
                        case "2":
                            Console.Write("Enter withdrawal amount: R");
                            string withdrawInput = Console.ReadLine();
                            Withdraw(withdrawInput, ref balance);
                            break;
                        case "3":
                            CheckBalance(balance);
                            break;
                        case "4":
                            Console.WriteLine("\nThank you for using the Bank Account program. Goodbye!");
                    break;
                        default:
                            Console.WriteLine("\nInvalid choice. Please enter 1, 2, 3, or 4.");
                            break;
                    }
                } while (choice != "4");
            }
            else
            {
                Console.WriteLine("Invalid starting balance. Please enter a valid positivenumber.");
            }
            Console.ReadKey();
        }
        private static void Deposit(string input, ref decimal balance)
        {
            decimal total;
            if (decimal.TryParse(input, out total) && total >= 0)
            {
                balance += total;
                Console.WriteLine($"\n{total:C2} deposited successfully.\nNew balance: {balance:C2}");
            }
            else 
            {
                Console.WriteLine("Invalid Entry, Please try again. ");
            }
        }
        private static void Withdraw(string input, ref decimal balance)
        {
            decimal total;
            if (decimal.TryParse(input, out total) && total >= 0)
            {
                if (total <= balance)
                {
                    balance -= total;
                    Console.WriteLine($"{total:C2} withdrawn successfully.\nNew balance: {balance:C2}");
                }
                else
                {
                    Console.WriteLine($"\nInsufficient funds. Your current balance is {balance:C2}.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Entry, Please try again. ");
            }
        }

        private static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"\nYour current balance is: {balance:C2}");
        }
    }
}
