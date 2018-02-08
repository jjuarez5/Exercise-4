using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class Spaceship
    {
        public string spaceshipName;
        public int shipInventory = 1000;

        // Declared for future builds
        public int shipMaxSpeed;
        // Declared for future builds
        public int shipMaxInventory;

        // Not 100% sure what this does with the array now existing.
        // Saving as active code for future builds.
        public Spaceship(string spaceshipName)
        {
            this.spaceshipName = spaceshipName;
        }

        // Method to receive purchase order "boughtSupplies" and
        // increase shipInventory = then return shipInventory.
        public int IncreaseShipInventory(int orderedSupplies)
        {
            this.shipInventory += orderedSupplies;
            return shipInventory;
        }


        // Method to decrease inventory if supplies sold
        public int DecreaseShipInventory(int invoicedSupplies)
        {
            int suppliesSold = 0;

            if (invoicedSupplies > this.shipInventory)
            {
                Console.WriteLine("Your current inventory will not support this transaction.\n");
                Console.WriteLine("Do you want to sell all your supplies?\n");
                Console.Write("Enter 'Y' to continue or enter to cancel.");

                try
                {

                    char yesNo = char.Parse(Console.ReadLine());
                    yesNo = char.ToUpper(yesNo);
                    if (yesNo == 'Y')
                    {
                        suppliesSold = this.shipInventory;
                        this.shipInventory = 0;
                    }
                }
                catch (FormatException)
                { ; }
            }
            else
            {
                suppliesSold = invoicedSupplies;
                this.shipInventory -= invoicedSupplies;
            }
            return suppliesSold;
        }
    }
}
