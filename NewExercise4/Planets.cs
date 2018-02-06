using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class Planets
    {
        string currentPlanet = ("Earth");
        public string myPlanet;
        public string determinePlanet()
        {
            myPlanet = currentPlanet;
            return myPlanet;
        }
    }
}
