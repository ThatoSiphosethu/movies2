using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Video : Type
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }
      //  public object Id { get;  set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}