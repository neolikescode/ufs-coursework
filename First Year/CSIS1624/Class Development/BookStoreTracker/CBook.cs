using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTracker
{
    class CBook
    {
        private string sTitle;
        private int iPages;
        private decimal dPrice;

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

        public CBook()
        {

        }

        public void DisplayBookInfo()
        {
            string sInfo = $"Book Information:\nTitle: {Title} \n" +
                           $"Number of Pages: {Pages} \nPrice: {Price:C2} ";

            Console.WriteLine(sInfo);
        }

    }
}
