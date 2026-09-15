using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTracker
{
    internal class CBook
    {
        //Three private fields: sTitle (string), iPages (int), dPrice (decimal).
        private string sTitle;
        private int iPages;
        private decimal dPrice;

        //A public property for each field, matching type and capitalised name.
        public string Title
        {
            get { return sTitle; }
            set { sTitle = value; }
        }
        public int Pages
        {
            get { return iPages; }
            set { iPages = value; }
        }
        public decimal Price
        {
            get { return dPrice; }
            set { dPrice = value; }
        }
        // A default constructor.
        public CBook()
        {

        }
        /*A DisplayBookInfo method that writes all the book's details to the screen, with the
        price shown to 2 decimal places.*/

        public void DisplayBookInfo()
        {
            string sInfo = $"Book Name: \t{Title}\nBook Length: {Pages}\nPrice: \t{Price:C2}";
            Console.WriteLine(sInfo);
        }

    }
}
