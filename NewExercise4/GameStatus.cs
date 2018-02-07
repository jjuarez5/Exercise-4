using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class GameStatus
    {
        // Establishing Current planet and ship
        Planets currentPlanet;
        Spaceship currentShip;
        User currentUser;
        double totalTravel = 0;

        // Establishing Planet Array
        Planets[] planetList = { new Planets("Earth", new Atlas(0, 0), (10), (9)),
                                 new Planets("Solstheim", new Atlas(0, 12.3), (20), (10)),
                                 new Planets("Corneria", new Atlas(1.2,9.3), (5), (100) ),
                                 new Planets("Nayru Prime", new Atlas(30.2,0), (50),(60))};
        // Establishing SpaceShip Array
        Spaceship[] spaceshipList = { new Spaceship("USS GOLDIE HAWN"),
                                      new Spaceship("USS TEXAS"),
                                      new Spaceship("USS ULYSSES S. GRANT")};

        // Method to initilize "current items" which are arrays
        public GameStatus()
        {
            currentPlanet = planetList[0];
            currentShip = spaceshipList[0];
            currentUser = new User();
        }

        // This method calls the main menu, choose option and determines if user wants to quit
        public void NewGame()
        {
            var exitGame = false;

            do
            {
                MainMenu();
                GameOver();
                ChooseOption();              
                exitGame = ActOnSelectedItem(UserInput());
                
            } while (!exitGame);
        }

        // Method to display Main Menu for current game with current STATS 
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine(" You are a Space Ranger!!!");
            Console.WriteLine(" Collect as many credits as possible! ");
            Console.WriteLine(" Your game will end if your account balance is 0!!\n");

        // Call Method for current planet
            Console.WriteLine($"Your current Planet is: {currentPlanet.planetName}");

        // Call Method for current ship
            Console.WriteLine($"You are traveling on the: {currentShip.spaceshipName}");

        // Call Method for current supply level
            Console.WriteLine($"Your current Supply Level is: {currentShip.shipInventory} supply cases");

        // Call Method for current account balance
            Console.WriteLine($"Your current Account Balance is: {currentUser.accountBalance} credits\n"); 

        }

        // Method to display choose an option to Travel or Buy/Sell
        public void ChooseOption()
        {
            Console.WriteLine(" Choose an option :");
            Console.WriteLine(" 1. Travel");
            Console.WriteLine(" 2. Buy/Sell Supplies");
            Console.WriteLine(" 3. Change your Spaceship");
            Console.WriteLine(" 0. Exit/Quit\n");
        }

        // Method to read user input
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

        // Method to call method based on user input
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
                case 3:
                    ChangeYourShip();
                    break;
                case 0:
                    exitGame = true;
                    break;
                default:
                    break;
            }
            return exitGame;
        }

        private void ChangeYourShip()
        {
            Console.Clear();
            Console.WriteLine("Space Ranger Docking Station \n");
            Console.Write("Choose a Space Ship : \n");
            for (var i = 0; i < spaceshipList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {spaceshipList[i].spaceshipName}");
            }
            Console.WriteLine("0. Go Back\n");

            var selected = UserInput();

            if ((selected == 0) || ((selected) > spaceshipList.Length) || (selected < 0))
            {
                ;
            }
            else if (this.currentShip == spaceshipList[selected - 1])
            {
                Console.Write("You're already on this awesome ship!!!\nPress enter to continue");
                Console.ReadLine();
            }
            else if ((selected <= spaceshipList.Length) && (selected > 0))
            {
                Console.Clear();
                currentShip = spaceshipList[selected - 1];
                Console.WriteLine($"Welcome Aboard the {currentShip.spaceshipName}\n");
                Console.WriteLine("Fair winds and following seas Space Ranger!\n");
                Console.Write("Press enter to continue...");
                Console.ReadLine();
            }
        }

        // TODO Method to display stats and "Game Over"
        public void GameOver()
        {
            if (currentUser.accountBalance == 0) 
            {
                Console.Clear();
                Console.WriteLine("G A M E   O V E R");
                Console.WriteLine("_______________________");
                Console.WriteLine($"You traveled a total of {totalTravel} light years.");
                Console.WriteLine($"You ended up with a total {currentUser.accountBalance} credits.");
                Console.WriteLine($"You ended your journey on Planet {currentPlanet.planetName}.");
                Console.WriteLine("Thanks for playing, Space Ranger. You did an okay job.");

            }
        }

        private void BuySellSupplies()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to Planet {currentPlanet.planetName}");
            Console.WriteLine("Supplies here cost:\n");
            Console.WriteLine($"1. Buying supplies here will cost you {currentPlanet.supplyBuyPrice} credits per case!");
            Console.WriteLine($"2. Selling supplies here will make you {currentPlanet.supplySellPrice} credits per case! ");
            Console.WriteLine("0. Go Back\n");

            var exitSale = false;
            var orderedSupplies = 0;
            var invoicedSupplies = 0;

            switch (UserInput())
            {
                case 1:
                    Console.Write("Enter the number of cases you would like to buy: ");
                    orderedSupplies = int.Parse(Console.ReadLine());
                    currentShip.IncreaseShipInventory(orderedSupplies);
                    var moneySpent = (orderedSupplies * currentPlanet.supplyBuyPrice);
                    currentUser.DecreaseUserBalance(moneySpent);

                    Console.WriteLine($"Wow, Space Ranger! Your total supply inventory will now be {currentShip.shipInventory} supply cases!");
                    Console.WriteLine($"This is going to cost you {moneySpent} credits!!");
                    Console.ReadLine();

                    break;
                case 2:
                    Console.Write("Enter the number of cases you would like to sell: ");
                    invoicedSupplies = int.Parse(Console.ReadLine());
                    currentShip.DecreaseShipInventory(invoicedSupplies);
                    var moneyMade = (invoicedSupplies * currentPlanet.supplySellPrice);
                    currentUser.IncreaseUserBalance(moneyMade);

                    Console.WriteLine($" You're new inventory will be {currentShip.shipInventory} supply cases!!");
                    Console.WriteLine($"Hey there, Money Bags!! You will have {moneyMade} credits added to your balance!!");
                    Console.ReadLine();

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

        private double SpaceTravel()
        {
            Console.Clear();
            Console.WriteLine("Space Ranger Travel \n");
            Console.WriteLine("Choose a location to travel to : \n");
            for (var i = 0; i < planetList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {planetList[i].planetName}");
            }
            Console.WriteLine("0. Go Back\n");

            double speed = 0.0;

            var selected = UserInput();

            if ( (selected > 0) && (selected <= planetList.Length) )
            {
                if (this.currentPlanet == planetList[selected - 1])
                {
                    Console.WriteLine("You're already on this planet...\nPress enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    speed = WarpSpeed();
                    var distance = this.currentPlanet.location.DistanceAway(planetList[selected - 1].location);
                    Console.Clear();
                    currentPlanet = planetList[selected - 1];
                    Console.WriteLine($"You made it to {currentPlanet.planetName}\n");
                    Console.WriteLine($"You traveled {distance} light years at {speed} times the speed of Light!  ZOOOM!\n");
                    totalTravel += distance;
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    
                }
            }return totalTravel;
        }

        // This method will calculate warp speed to speed of light after obtaining input.
        private double WarpSpeed()
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
                        return Math.Round(speed, 2);
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
