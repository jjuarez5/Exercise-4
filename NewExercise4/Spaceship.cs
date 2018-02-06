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
        public int shipInventory = 0;

        public string determineShip()
        {
            myShip = currentShip;
            return myShip;
        }


        //Method to receive purchase order "boughtSupplies" and
        //increase shipInventory = then return shipInventory.
        public int IncreaseShipInventory(int boughtSupplies)
        {
             this.shipInventory += boughtSupplies;
             return shipInventory;
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
