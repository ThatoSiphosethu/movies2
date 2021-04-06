using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Show : Type
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }
      //  public int Id { get;  set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}