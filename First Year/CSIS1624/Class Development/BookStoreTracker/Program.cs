using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many books do you want to keep track of? ");
            string userResponse = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(userResponse) && int.TryParse(userResponse, out int arraySize) && arraySize > 0)
            {
                CBook[] books = new CBook[arraySize];
                
                decimal dTotal = 0;

                for (int i = 0; i < books.Length; i++)
                {
                    Console.Clear();
                    books[i] = new CBook(); 

                    Console.Write("Enter book title: ");
                    string sTitle = Console.ReadLine();
                    books[i].Title = sTitle;

                    Console.Write("Enter number of pages of the book: ");
                    int iPage = int.Parse(Console.ReadLine());
                    books[i].Pages = iPage;

                    Console.Write("Enter book price: ");
                    decimal dPrice = decimal.Parse(Console.ReadLine());
                    books[i].Price = dPrice;
                    dTotal += dPrice;
                }
                decimal dAverage = dTotal/books.Length;

                foreach(CBook bookStored in books)
                {
                    bookStored.DisplayBookInfo();
                    
                }
               Console.WriteLine($" The total average for the books is {dAverage:C2}\n");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Please enter a valid number. ");
            }
        }
    }
}
