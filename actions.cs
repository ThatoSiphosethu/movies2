using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieLibrary
{
    class Actions
    {
        public List<Movie> Movies {get; set;}
        private static string File1 = "movies.csv";
        public List<Show> Shows {get; set;}
        private static string File2 = "shows.csv";
        public List<Video> Videos {get; set;}
        private static string File3 = "videos.csv";
        //private object show;

        public Actions(){
            Movies = new List<Movie>();
            Movie movie = new Movie();   
            Movies.Add(movie);

            Shows = new List<Show>();
            Show show = new Show();
            Shows.Add(show);

            Videos = new List<Video>();
            Video video = new Video();   
            Videos.Add(video);
        }
       
        // generate questions
        public void ReadMovies()
        {
            Console.WriteLine("How many movie do you want to be displayed? ");
            int numberOfMovies = Int32.Parse(Console.ReadLine());

            StreamReader reader = new StreamReader("movies.csv");

            for (int i = 0; i < numberOfMovies + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

        // Add  new movie
        public void AddMovie(Movie movie)
        {
            movie.Id = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File1, true);

            Console.WriteLine("Enter a new Title: ");
            string Title = Console.ReadLine();

            var genres = new List<string>();
            string genre;
            string option;

            do
                {
                     Console.WriteLine("Add genres: ");
                     genre = Console.ReadLine();
                     genres.Add(genre);
                     Console.WriteLine("Do you want to add a genre: (Y/N)");
                     option = Console.ReadLine().ToUpper();
                } 
            while (option == "Y");

            string newGenres = string.Join("|", genres);
            sw.WriteLine("{0},{1},{2}", movie.Id, movie.Title, movie.Genres);
            sw.Close();
        }

        // new showID
        private int getLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File1).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {       
                 Console.WriteLine("File does not exist.");
            }
            
            return lastID;
        }
                

        // generate questions
         public void ReadShows()
         {
             Console.WriteLine("How many shows do you want to be displayed? ");
             int numberOfShows = Int32.Parse(Console.ReadLine());

             StreamReader reader = new StreamReader("shows.csv");

           for (int i = 0; i < numberOfShows + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
         }

        // Add  new Show
        public void AddShows(Show shows)
         {
            shows.Id = showsLastID() + 1;
            StreamWriter sw = new StreamWriter(File2, true);

            Console.WriteLine("Enter Title: ");
            string showTitle = Console.ReadLine();

            Console.WriteLine("Input season number: ");
            int Season = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inpt episode number: ");
            int Episode = Int32.Parse(Console.ReadLine());

            

            var Writers = new List<string>();
            string Writer;
            string option;

        

            do
                {
                    Console.WriteLine("Add writer/s: ");
                    Writer = Console.ReadLine();
                    Writers.Add(Writer);
                    Console.WriteLine("Do you want to add writer/s: (Y/N)");
                    option = Console.ReadLine().ToUpper();
                } 
            while (option == "Y");

            string newWriter = string.Join("|", Writers);
            sw.WriteLine("{0},{1},{2},{3},{4},{5}", shows.Id, shows.Title,shows.Season, shows.Episode, shows.Writers);
            sw.Close();
        }

        
         private int showsLastID()
         {
            int lastID = 0;
            try
                {
                    string lastLine = System.IO.File.ReadLines(File2).Last();
                    string[] lastLineSplit = lastLine.Split(',');
                    lastID = Convert.ToInt32(lastLineSplit[0]);
                    return lastID;
            }
            catch (DirectoryNotFoundException)
                {
                   Console.WriteLine("File does not exist.");
                }
            return lastID;
         }

         public void ReadVideos()
        {
            Console.WriteLine("How many videos do you want to be displayed? ");
            int numberOfVidoes = Int32.Parse(Console.ReadLine());

            StreamReader reader = new StreamReader("videos.csv");

            for (int i = 0; i < numberOfVidoes + 1; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

        // Add  new movie
        public void AddVide(Video video)
        {
            video.Id = videosLastID() + 1;
            StreamWriter sw = new StreamWriter(File3, true);

            Console.WriteLine("Enter a new Title: ");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter a format: ");
            string Format = Console.ReadLine();

            Console.WriteLine("Enter length of video: ");
            int Length = Int32.Parse(Console.ReadLine());

            var Regions = new List<string>();
            string Region;
            string option;

            do
                {
                     Console.WriteLine("Add region: ");
                     Region = Console.ReadLine();
                     Regions.Add(Region);
                     Console.WriteLine("Do you want to add a region: (Y/N)");
                     option = Console.ReadLine().ToUpper();
                } 
            while (option == "Y");

            string newRegions = string.Join("|", Regions);
            sw.WriteLine("{0},{1},{2},{3},{4},{5}", video.Id, video.Title, video.Format, video.Length, video.Regions);
            sw.Close();
        }

        // new showID
        private int videosLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File3).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {       
                 Console.WriteLine("File does not exist.");
            }
            
            return lastID;
        }
        
    
    }
      
}