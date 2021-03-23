using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MovieLibrary
{
     class Show : Type
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}