using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class Planets
    {
        public string planetName;
        public Atlas location;

        public Planets(string planetName, Atlas location)
        {
            this.planetName = planetName;
            this.location = location;
        }
    }
}
