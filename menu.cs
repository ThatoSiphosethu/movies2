using System;
using System.IO;

namespace MovieLibrary
{
    public class Menu
    {
        //public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void Questions(){
            Console.WriteLine("Make a selection\n");
            Console.WriteLine("1. View ");
            Console.WriteLine("2. Add ");
            Console.WriteLine("3. Exit\n");
 
        }

        public void MenuSelection() {
        int choice = 0;
        string option;


        do
        {
            
            Questions();
            choice = Int32.Parse(Console.ReadLine());
            if(choice == 1)

            {
                int media = 0; 

                Console.WriteLine("Do you want to view 1. Movies, 2. Series, 3. Videos? "); 
                media = Console.ReadLine();

                if (media == 1)
                {
                    //read from movies.csv
                    
                }

                 else if (media == 2)
                {
                    //read from shows.csv
                     StreamReader rs = new StreamReader(file2);
                    Console.WriteLine("ShowId,ShowTitle,Episode,Writers");
                    Console.WriteLine("");
                    while (!rs.EndOfStream)
                    {
                        string line = rs.ReadLine();
                        Console.WriteLine(line);
                    }
                }

                 else if (media == 3)
                {
                    //read from videos.csv
                      StreamReader rt = new StreamReader(file3);
                    Console.WriteLine("VideoId,VideoTitle,Format,Length,Regions");
                    Console.WriteLine("");
                    while (!rt.EndOfStream)
                    {
                        string line = rt.ReadLine();
                        Console.WriteLine(line);
                    }
                }

                else(MenuSelection)

            }

            if(choice == 2)

            {
                int add = 0; 

                Console.WriteLine("Do you want to add 1. Movies, 2. Series, 3. Videos? "); 
                add = Console.ReadLine();

                if (add == 1)
                {
                    //write to  movies.csv
                    
                }

                 else if (add == 2)
                {
                    //write shows.csv
                    
                }

                 else if (add == 3)
                {
                    //write videos.csv
                    
                }

                else(MenuSelection)

            }

            else(break);

        }




    }
} 
}