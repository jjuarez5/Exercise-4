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
                Console.Write(" Make a selection :");

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
            Console.Clear();
            Console.WriteLine("Space Ranger Travel \n");
            Console.WriteLine("Choose a location to travel to : \n");
            Console.WriteLine("1. Tellar Prime");
            Console.WriteLine("2. Home Planet");
            Console.WriteLine("0. Go Back\n");

            var goBack = false;
            double speed = 0.0;

            // This switch case will perform treavel portion of game
            //User can also "go back" if travel is not desired
            switch (UserInput())
            {
                case 1:
                    Console.WriteLine("Enter your cruising WARP speed.");
                    Console.WriteLine("Speed can be 0.1 to 9.9\n");
                    Console.Write("Speed: ");
                    speed = double.Parse(Console.ReadLine());
                    //test for valid input here
                    //calculate distance, speed etc


                    //may need to break this out into the planet's as a method there
                    //Each planet should have a welcome screen with costs etc.
                    Console.WriteLine("Welcome to Tellar Prime!");
                    Console.WriteLine($"You traveled XX miles at {speed} Speed...");
                    break;
                case 2:
                    Console.WriteLine("You're already at your home planet");
                    break;
                case 0:
                    goBack = true;
                    break;
            }
        }
    }
}
