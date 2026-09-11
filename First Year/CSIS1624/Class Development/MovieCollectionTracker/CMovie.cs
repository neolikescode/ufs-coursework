using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionTracker
{
    class CMovie
    {
        private string sTitle;
        private int iDuration;
        private decimal dPrice;

       
        public string Title
        {
            get { return sTitle; }
            set { sTitle = value; }
        }
        
        public int Duration
        {
            get { return iDuration; }
            set { iDuration = value; }
        }
        
        public decimal RentalPrice
        {
            get { return dPrice; }
            set { dPrice = value; }
        }

        public CMovie()
        {

        }

        public string DisplayMovieInfo()
        {
            return $"Movie Information\n\nTitle: {Title}\nDuration: {Duration}\nRental Price: {RentalPrice:C2}";
        }

    }
}
