using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4_Advanced.FifaGame
{
    internal class Ball
    {
        public int ID { get; set; }
   
        private Location location;

        public Location Locationn
        {
            get { return location; }

            set {
                if (!value.Equals(location))
                {
                    location = value;

                    //notify Sub
                    Ballchanged?.Invoke();
                }
              
               }
        }
        public event Action? Ballchanged; 
        public override string ToString()
        {
            return ($"ID {ID}, location {location}"); 
        }

    }
}
