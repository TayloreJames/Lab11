
using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = Movie.CreateMovieList();

            Console.WriteLine("Welcome to the Movie List Application!\n");

            do
            {
                Movie.CreateListOfCategories();
                
                Console.Write("\nEnter number of category you're interested in: ");
            
                var categorySelection = Console.ReadLine();

                Movie.CreateSelectedCategoryList(categorySelection, movies);
            } while (Continue.DetermineStatus());

            Console.ReadKey();
        }       
    }
}
