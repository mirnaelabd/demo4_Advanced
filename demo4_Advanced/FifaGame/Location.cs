using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.FifaGame
{
    public struct Location
    {
        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public override string ToString()
        {
            return ($"x:{x} , y:{y}, z:{z}");
        }
    }
}
