using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class Spaceship
    {
        public string currentShip = ("EarthWorm Jim");
        public string myShip;
        public int supplies = 0;

        public string determineShip()
        {
            myShip = currentShip;
            return myShip;
        }

        // code structure by argiopetech
        public void InboundSupplies(int onLoadedSupplies)
        {
            this.supplies += onLoadedSupplies;
        }

        // code structure by argiopetech
        public int OutboundSupplies(int offLoadedSupplies)
        {
            int suppliesSold;

            if (offLoadedSupplies > this.supplies)
            {
                suppliesSold = this.supplies;
                this.supplies = 0;
            }
            else
            {
                suppliesSold = offLoadedSupplies;
                this.supplies -= offLoadedSupplies;
            }
            return suppliesSold;
        }
    }
}
