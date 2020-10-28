using System;
using System.Net.NetworkInformation;

namespace TheMovies
{
    class Program
    {
        static void Main(string[] args)
        {


            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-13");
                Movies shrek = new Movies("Shrek", "Adam", "PG");

            shrek.Rating = "R";
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
