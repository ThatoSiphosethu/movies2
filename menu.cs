using System;
using System.IO;

namespace MovieLibrary
{
     public class Menu
    {
        public void Questions()
        {
           
            int option = 0;

            do
            {
                Console.WriteLine("1. View\n2. Add\n3. Exit");

                option = Int32.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Menu ViewMenu = new Menu();
                    Actions actions = new Actions();
                    int choice = 0;
                    Console.WriteLine("1. Movie\n2. Video\n3. Show\n4. Back\n5. Exit");
                    if (choice == 1)
                    {
                        actions.ReadMovies();
                    }
                    else if (choice == 2)
                    {
                        actions.ReadShows();
                    }
                    else if (choice == 3)
                    {
                       actions.ReadVideos(); 
                    }
                    else if(choice == 4)
                    {
                        return;
                    }
                }
                else if (option == 2)
                {
                    Menu AddMenu = new Menu();
                    Console.WriteLine("Add into 1. Movie\n. 2 Video\n. 3 Show\n ");
                    int choice = 0;
                    Actions actions = new Actions();
                    if (choice == 1)
                    {
                        actions.AddMovie();
                    }
                    else if (choice == 2)
                    {
                        actions.AddVideos();  
    
                    }
                    else if (choice == 3)
                    {
                        actions.AddShows();
                    }
                  
                }

                else if (option == 3)
                {
                    Menu exit = new Menu();
                }
            } while (option != 4);
            
            
            }

        // internal static void Choice()
        // {
        //     throw new NotImplementedException();
        // }
    }      
             
}
