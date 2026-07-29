using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List stores prices of products
            List<decimal> prices = new List<decimal>();

            //Display Title
            Console.WriteLine("========== Shopping Cart System ==========\n");

            //Prompt user to enter the number of products they are buying
            Console.Write("How many products are you adding? ");
            int numOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //stores the total value of the products user will add
            decimal total = 0;
            decimal mostExpensive = 0;
            int expensiveProduct = 0;
            //Prompts user to enter prices of products and collects the prices in List variable
            for (int i = 0; i < numOfProducts; i++)
            {
                Console.Write($"Enter product {i + 1} price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                prices.Add(price);
                total += price;

                if (price > mostExpensive)
                {
                    mostExpensive = prices[i];
                    expensiveProduct = i;
                }
                
            }

            Console.WriteLine("\n========== SHOPPING CART ==========");
            for (int i = 0; i < prices.Count; i++)
            {
                Console.Write($"Product {i + 1}: {prices[i]:C2}\n");
            }
            //Displays the product number and it's price
            Console.WriteLine($"Total: {total:C2}");
            Console.WriteLine("===================================");

            //Finds the Most expensive item and displays it
            Console.WriteLine($"Most Expensive Item: \nProduct {expensiveProduct+1} \nPrice: {mostExpensive:C2}");

            //Prompts user to enter in price of item they want to remove
            Console.Write("Enter the price of the item you want to remove: ");
            decimal remove = decimal.Parse(Console.ReadLine());

            //Displays appropriate message for the user regarding removing an item
            if (prices.Remove(remove))
            {
                Console.WriteLine();
                Console.WriteLine("Item removed successfully ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Item not found ");
            }
            //Displays the final Shopping Cart
            Console.WriteLine("\n========== SHOPPING CART ==========");
            int counter = 1;
            mostExpensive = 0;
            expensiveProduct = 0;
            total = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                if (prices[i] > mostExpensive)
                {
                    mostExpensive = prices[i];
                    expensiveProduct = i;
                }
            }
            foreach(decimal amount in prices)
            {
                Console.Write($"Product {counter} {amount:C2}\n");
                counter++;
                total += amount;
            }
            //Finds the Most expensive item and displays it
            Console.WriteLine($"Most Expensive Item: \nProduct {expensiveProduct + 1} \nPrice: {mostExpensive:C2}");
            //Displays Total
            Console.WriteLine($"Total: {total:C2}");

        }
    }
}
