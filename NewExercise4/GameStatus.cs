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
        Planets currentPlanet;

        Planets[] planetList = { new Planets("Earth", new Atlas(0, 0)),
                                 new Planets("Yeranos", new Atlas(0, 12.3)),
                                 new Planets("Far Away", new Atlas(22.8,9.3)),
                                 new Planets("Even Further Away", new Atlas(30.2,0))};
        public string myShip = "";

        public GameStatus()
        {
            currentPlanet = planetList[0];
        }

        //This method calls the main menu, choose option and determines if user wants to quit
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
            Console.Clear();
            Console.WriteLine(" You are a Space Ranger!!!");
            Console.WriteLine(" Collect as many credits as possible. \n");

            //Call Method for current planet
            Console.WriteLine($"Current Planet is: {currentPlanet.planetName}");

            //Call Method for current ship
            myShip = new Spaceship().determineShip();//Need to call this publically first then variable it
            Console.WriteLine($"Current Ship is: {myShip}");

            //Call Method for current supply level
            Console.WriteLine("Current Supply Level is: "); // + SupplyLevel();

            //Call Method for current account balance
            Console.WriteLine("Current Account Balance is: \n"); //+ {currentBalance});

        }

        //Method to display choose an option to Travel or Buy/Sell
        public void ChooseOption()
        {
            Console.WriteLine(" Choose an option :");
            Console.WriteLine(" 1. Travel");
            Console.WriteLine(" 2. Buy/Sell Supplies");
            Console.WriteLine(" 0. Exit/Quit\n");
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

        // This method contains a switch case to determine if user
        // wants to continue to Travel/Buy-Sell or Quit.
        private bool ActOnSelectedItem(int selection)
        {
            var exitGame = false;

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
                default:
                    break;
            }
            return exitGame;

            //Method to display stats and "Game Over"
            //If game over, change variable to end game in RunGame
        }

        private void BuySellSupplies()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Planet... \n");
            Console.WriteLine("Supplies here cost:\n");
            Console.WriteLine("1. To Buy: ");
            Console.WriteLine("2. To Sell: ");
            Console.WriteLine("0. Go Back\n");

            var exitSale = false;

            switch (UserInput())
            {
                case 1:
                    //PurchaseNewSupplies(); //This method should reside HERE
                    //UpdateSupplies(); //This method should reside in the Ship Class
                    //UpdateUserBalance(); //This method wshould reside in the User Class
                    break;
                case 2:
                    //SellExistingSupplies(); //This method should reside HERE
                    //UpdateSupplies(); //This method should reside in the Ship Class
                    //UpdateUserBalance(); //This method wshould reside in the User Class
                    break;
                case 0:
                    exitSale = true;
                    break;
                default:
                    Console.WriteLine("Please select 0, 1 or 2!");
                    Console.ReadLine();
                    break;
            }
        }

        private void SpaceTravel()
        {
            Console.Clear();
            Console.WriteLine("Space Ranger Travel \n");
            Console.WriteLine("Choose a location to travel to : \n");
            for (var i =0; i<planetList.Length;i++)
            {
              
                Console.WriteLine($"{i+1}. {planetList[i].planetName}");
            }
            Console.WriteLine("0. Go Back\n");


            var goBack = false;
            double speed = 0.0;

            // This switch case will perform treavel portion of game
            //User can also "go back" if travel is not desired
            var selected = UserInput();

            //Make into an if statement to test if at max array limit...
            switch (selected)
            {
                case 1:
                    speed = warpSpeed();
                    //may need to break this out into the planet's as a method there
                    //Each planet should have a welcome screen with costs etc.
                    Console.Clear();
                    currentPlanet = planetList[selected];
                    Console.WriteLine($"You made it to {currentPlanet.planetName}\n");
                    Console.WriteLine($"You traveled XX light years at {speed} times the speed of Light!  ZOOOM!\n");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You're already at your home planet");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case 0:
                    goBack = true;
                    break;
                default:
                    break;
            }
        }

        //This method will calculate warp speed to speed of light after obtaining input.
        private double warpSpeed()
        {
            var input = false;

            double i = 0.0;
            double speed = 0.0;

            do
            {
                Console.WriteLine("Enter your cruising WARP speed.");
                Console.WriteLine("Speed can be 0.1 to 9.9\n");
                Console.Write("Speed: ");
                try
                {
                    i = double.Parse(Console.ReadLine());
                    if ((i < 10) && (i > 0))
                    {
                        speed = (Math.Pow(i, (10 / 3)) + ((Math.Pow((10 - i), (-11 / 3)))));
                        input = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Come on Space Ranger, set your Warp speed correctly! Try again!");
                }
            } while (!input);

            return speed;            
        }
       
    }
}
