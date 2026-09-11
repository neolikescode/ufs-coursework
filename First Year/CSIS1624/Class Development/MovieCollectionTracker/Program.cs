using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many movies do you want to keep track of? ");

            CMovie[] movies = new CMovie[int.Parse(Console.ReadLine())];

            for(int i = 0; i < movies.Length; i++)
            {
                Console.Clear();
                movies[i] = new CMovie();

                Console.Write("Enter movie title: ");
                string sMovie = Console.ReadLine();
                movies[i].Title = sMovie;

                Console.Write("Enter movie duration: ");
                int iDuration = int.Parse(Console.ReadLine());
                movies[i].Duration = iDuration;

                Console.Write("Enter rental price: ");
                decimal dPrice = decimal.Parse(Console.ReadLine());
                movies[i].RentalPrice = dPrice;
            }
            Console.Clear();
            decimal dTotal = 0;
            foreach(CMovie movie in movies)
            {
                Console.WriteLine(movie.DisplayMovieInfo());
                dTotal += movie.RentalPrice;
            }
             decimal dAverage = dTotal/movies.Length;
            Console.WriteLine($"Average movie rental price: {dAverage:C2}");

            Console.WriteLine("Press any key to exit... ");
            Console.ReadKey(true);
        }
    }
}
