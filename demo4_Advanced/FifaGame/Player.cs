using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.FifaGame
{
    internal class Player
    {
        public string PlayerName {  get; set; }
        public string TeamName { get; set; }

        public void Run()
        {
            Console.WriteLine($"player{PlayerName} is running ");
        }


    }
}
