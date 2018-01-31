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

        public void MainMenu()
        {
            //string currentPlanet = "Earth"; //Hard Code
            //string currentShip = "USS Yogi Bear"; //Hard Code

            Console.WriteLine(" You are a Space Ranger!!!");
            Console.WriteLine(" Collect as many credits as possible. \n");

            //Call Method for current planet
            Console.WriteLine("Current Planet is: "); // planet.currentPlanet from new class
 
            //Call Method for current ship
            Console.WriteLine("Current Ship is: "); // ship.currentPlanet from new class

            //Call Method for current supply level
            Console.WriteLine("Current Supply Level is: " + supplyLevel());

            //Call Method for current account balance
            Console.WriteLine("Current Account Balance is: " + accountBalance());

            //Call Method to display choose an option
            chooseOption();

        }

        private string currentShip()
        {
            throw new NotImplementedException();
        }

        private string currentPlanet()
        {
            throw new NotImplementedException();
        }

        private void chooseOption()
        {
            throw new NotImplementedException();
        }

        private string accountBalance()
        {
            throw new NotImplementedException();
        }

        private string supplyLevel()
        {
            throw new NotImplementedException();
        }

        //Method to check current planet
        //Initial game will hard code planet till more are available

        //Method to check current ship
        //Initial game will hard code ship till more are available

        //Method to check supply levels

        //Method to check account balance

        //Method to display choose an option
        //Display options on main menu only
        //Call Method to read user input


        //Method to read user input
        //Switch case to call methods (method to call methods)

        //Method to display stats and "Game Over"
        //If game over, change variable to end game in RunGame
    }
}
