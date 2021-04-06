using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Movie : Type
    {
        public string[] Genres { get; set; }
       // public int Id { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}
