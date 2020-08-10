using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Movie
    {
        private string _title { get; set; }
        private string _category { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public static List<Movie> CreateMovieList()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie("Predestination", "Sci-Fi"));
            movies.Add(new Movie("Inception", "Sci-Fi"));
            movies.Add(new Movie("In Time", "Sci-Fi"));
            movies.Add(new Movie("Spider-Man: Into the Spider-Verse", "Animated"));
            movies.Add(new Movie("Incredibles", "Animated"));
            movies.Add(new Movie("My Hero Academia: Two Heroes", "Animated"));
            movies.Add(new Movie("Parasite", "Drama"));
            movies.Add(new Movie("The Godfather", "Drama"));
            movies.Add(new Movie("The Cabin in the Woods", "Horror"));
            movies.Add(new Movie("Us", "Horror"));

            return movies;
        }

        public static void CreateListOfCategories()
        {
            var categoryArray = Enum.GetNames(typeof(MovieCategories));
            Console.WriteLine("Movie Categories:");
            for (int i = 0; i < categoryArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {categoryArray[i]}");
            }
        }

        public static void CreateSelectedCategoryList(string userInput, List<Movie> movies)
        {
            var stringMovieList = new List<string>();
            while (true)
            {
                if (userInput == "1")
                {
                    PrintSortedMovieList("Sci-Fi", stringMovieList, movies);
                    break;
                }
                else if (userInput == "2")
                {
                    PrintSortedMovieList("Drama", stringMovieList, movies);
                    break;
                }
                else if (userInput == "3")
                {
                    PrintSortedMovieList("Animated", stringMovieList, movies);
                    break;
                }
                else if (userInput == "4")
                {
                    PrintSortedMovieList("Horror", stringMovieList, movies);
                    break;
                }
                else
                {
                    Console.Write("\nInvalid Entry. Please select a valid entry 1-4: ");
                    userInput = Console.ReadLine();
                }
            }
        }

        public static void PrintSortedMovieList(string category, List<string> listForSorting, List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category == category)
                {
                    listForSorting.Add(movie.Title);
                }
            }
            listForSorting.Sort();
            foreach (var movie in listForSorting)
            {
                Console.WriteLine($"{movie}");
            }
        }
    }
}
