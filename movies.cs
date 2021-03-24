using System;
//using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace MovieLibrary
{
    public class Movie : Type
    {
       
        public string[] Genres { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    } 
}
