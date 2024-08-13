using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.FifaGame
{
    internal class Refree
    {
        public string RefreeName { get; set; }
        public void look()
        {
            Console.WriteLine($"Refree {RefreeName} is looking At ball");
        }
    }
}
