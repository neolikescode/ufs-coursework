using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("======== Book Store Tracker ========\n\n");
            Console.Write("How many books do you want to enter: ");
            string sNum = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(sNum) && int.TryParse(sNum, out int iNum))
            {
                try
                {
                    //Create an array of type Book storing 3 books
                    CBook[] books = new CBook[iNum];
                    
                    //Use a loop to prompt the user for each book's details, clearing the console before each new book
                    for(int i = 0; i < books.Length; i++)
                    {
                        Console.Clear();
                        //EACH LOOP CREATES A NEW INSTANCE OF CBOOK
                        books[i] = new CBook();

                        //Gets book title & store in appropriate property
                        Console.Write("Enter book title: ");
                        string sTitle = Console.ReadLine();
                        books[i].Title = sTitle;

                        //Gets book length & store in appropriate property
                        Console.Write("Enter number of pages of the book: ");
                        int iPages = int.Parse(Console.ReadLine());
                        books[i].Pages = iPages;

                        //Gets book price & store in appropriate property
                        Console.Write("Enter book price: ");
                        decimal dPrice = decimal.Parse(Console.ReadLine());
                        books[i].Price = dPrice;
                    }
                    //Clear the console again once all books have been captured
                    Console.Clear();

                    //Use a second loop to display each book's details via DisplayBookInfo
                    foreach(CBook bookInfo in books)
                    {
                        bookInfo.DisplayBookInfo();
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }
            Console.WriteLine("Press any key to exit...");
        }
    }
}
