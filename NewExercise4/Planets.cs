using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    // Class created with the basic structure presented by argiopetech on GitHub.com
    class Planets
    {
        public string planetName;
        public Atlas location;
        public int supplyBuyPrice;
        public int supplySellPrice;

        public Planets(string planetName, Atlas location, int supplyBuyPrice, int supplySellPrice)
        {
            this.planetName = planetName;
            this.location = location;
            this.supplyBuyPrice = supplyBuyPrice;
            this.supplySellPrice = supplySellPrice;
        }
    }
}
