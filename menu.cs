using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Menu
    {
        public static void Choice()
        {
            Console.WriteLine("1. View\n2. Add\n3. Exit");
            int option = Option();

            switch (option)
            {
                case 1: ViewMenu();
                    break;
                case 2: AddMenu();
                    break;
                case 3: return;
                    break;
                default: Console.WriteLine("Try again\n");
                    Choice();
                    break;
            }
        }

        public static void ViewMenu()
        {
            Console.WriteLine("1. Movie\n2. Video\n3. Show\n4. Back\n5. Exit");
            int option = Option();

            switch (option)
            {
                case 1:
                   ShowMovies();
                    break;
                case 2:
                   ShowVideos();
                    break;
                case 3:
                    ShowShows;
                    break;
                case 4: Back();
                    break;
                case 5:  return;
                    break;
                default:
                    Console.WriteLine("Try again\n");
                    ViewMenu();
                    break;
            }
        }


        public static void AddMenu() 
        {
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
