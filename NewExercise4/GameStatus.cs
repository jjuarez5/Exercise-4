using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class GameStatus
    {
        //Method to display the Main Menu
        //While currency == $0... yada yada
        //Call RunGame.UserInput();
        public void NewGame()
        {
            var exitGame = false;

            do
            {
                MainMenu();
                ChooseOption();
                exitGame = ActOnSelectedItem(UserInput());

            } while (!exitGame);
        }

        public void MainMenu()
        {
            //string currentPlanet = "Earth"; //Hard Code
            //string currentShip = "USS Yogi Bear"; //Hard Code

            Console.Clear();
            Console.WriteLine(" You are a Space Ranger!!!");
            Console.WriteLine(" Collect as many credits as possible. \n");

            //Call Method for current planet
            Console.WriteLine("Current Planet is: "); // planet.currentPlanet from new class

            //Call Method for current ship
            Console.WriteLine("Current Ship is: "); // ship.currentShip from new class

            //Call Method for current supply level
            Console.WriteLine("Current Supply Level is: "); // + SupplyLevel();

            //Call Method for current account balance
            Console.WriteLine("Current Account Balance is: \n"); //+ {currentBalance});
           
        }

        //Method to display choose an option
        public void ChooseOption()
        {
            Console.WriteLine(" Choose an option :");
            Console.WriteLine(" 1. Travel");
            Console.WriteLine(" 2. Buy/Sell Supplies");
            Console.WriteLine(" 0. Exit/Quit\n");
        }

        private void AccountBalance()
        {
            Console.WriteLine("Your Balance Method");
            //return currentBalance
        }

        private void SupplyLevel()
        {
            Console.WriteLine("Your Supply Level Method");
        }

        //Method to check supply levels

        //Method to check account balance

        //Method to read user input
        private int UserInput()
        {
            var input = false;

            int selection = 0;

            do
            {
                Console.WriteLine(" Make a selection :");

                try
                {
                    selection = int.Parse(Console.ReadLine());
                    input = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid selection, Space Ranger! Try again!");
                }
            } while (!input);

            return selection;

        }

        private bool ActOnSelectedItem(int selection)
        {
            var exitGame = false;

            // This switch case determines whether or not
            // user wants to continue to new game or exit.
            switch (selection)
            {
                case 1:
                    SpaceTravel();
                    break;
                case 2:
                    BuySellSupplies();
                    break;
                case 0:
                    exitGame = true;
                    break;
            }
            return exitGame;

            //Method to display stats and "Game Over"
            //If game over, change variable to end game in RunGame
        }

        private void BuySellSupplies()
        {
            Console.WriteLine("Buy/Sell Supplies");
        }

        private void SpaceTravel()
        {
            Console.WriteLine("Travel");
        }
    }
}
