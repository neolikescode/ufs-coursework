using System;
namespace Shop_Inventory_System___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String array will hold the names of the products
            string[] products =
            {
                "Mouse",
                "Keyboard",
                "Monitor"
            };
            //Double array will store the prices of the said products
            double[] prices =
            {
                150,
                300,
                2500
            };
            //Integer array will store the quantity of each product 
            int[] quantities =
            {
                5,
                2,
                4
            };
            //declared 2 variables that will store the value of the price and name of the product that is the most valuable
            double stockValue = prices[0] * quantities[0];
            string highestValProduct = products[0];
            //For loop will loop through all the arrays and display each element at its stored index
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"{products[i]} - {prices[i]:C2} - Quantity: {quantities[i]}");
                Console.WriteLine();
                double productValue = prices[i] * quantities[i];
                   
                //The if statement determines the highest value product and then updates the variables
                if ( productValue > stockValue )
                {
                    stockValue = productValue;
                    highestValProduct = products[i];
                }
            }
            //Output the name of the highest value product and its value
            Console.WriteLine($"{highestValProduct} has the highest stock value: {stockValue:C2}");

        }
    }
}
