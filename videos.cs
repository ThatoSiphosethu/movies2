using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MovieLibrary
{
     class Video : Type
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}