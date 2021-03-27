using System;
using System.IO;

namespace MovieLibrary
{
     public class Menu
    {
        public static void Choice()
        {
           
            Console.WriteLine("1. View\n2. Add\n3. Exit");
            int optionOne = Option();

            switch (optionOne)
            {
                case 1: ViewMenu();
                    break;
                case 2: AddMenu();
                    break;
                case 3: return;
                default: Console.WriteLine("Try again\n");
                    Choice();
                    break;
            }
        } 
        public static void ViewMenu()
        {
            Console.WriteLine("1. Movie\n2. Video\n3. Show\n4. Back\n5. Exit");
            int optionTwo = Option();

            switch (optionTwo)
            {
                case 1:
                   ShowMovies();
                    break;
                case 2:
                   ShowVideos();
                    break;
                case 3:
                    ShowShows();
                    break;
                case 4: Back();
                    break;
                case 5:  return;
                   default:
                    Console.WriteLine("Try again\n");
                    ViewMenu();
                    break;
            }
        }

        public static void ShowMovies(){
            //var movies = new Movies();
        }

        public static void ShowVideos(){}

        public static void ShowShows(){}

        public static void Back(){}
        public static void AddMenu() 
        {
            Console.WriteLine("Which file are you adding into?");
            int choice = choice();
            
            switch (choice)
            {
                
                case 1:
                 addMovie.add();
                    break;
                case 2:
                 addShow.add();
                    break;
                case 3:
                 addVideo();
                    break;
                case 4:
                 Back();
                case 5:
                 return;
                 break;

                default:
                    Console.WriteLine("Exit\n");
                    ViewMenu();
                    break;             
            }
            
        }
        public static int Option()
        {
            int option;
            while (true)
            {
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException exp)
                {
                    throw;
                }
            }
            return option;
        }       
    }
}