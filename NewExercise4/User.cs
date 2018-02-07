using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    public class User
    {
        // User starts with an initial balance of 1000 credits
        public int accountBalance = 1000;
      
        public int IncreaseUserBalance(int moneyMade)
        {
            this.accountBalance += moneyMade;
            return accountBalance;
        }


        // code structure by argiopetech
        public int DecreaseUserBalance(int moneySpent)
        {
            int moneyUsed;

            if ( moneySpent > this.accountBalance)
            {
                Console.WriteLine(" Your eyes want more than your wallet has to offer...");
                moneyUsed = this.accountBalance;
                this.accountBalance = 0;
            }
            else
            {
               moneyUsed = moneySpent;
                this.accountBalance -= moneySpent;
            }
            return moneyUsed;
        } 

        // Create a method to update user Balance =  current balance + Purchase supplies + Sell Supplies and
        // then return those variables to zero
        // Maybe separate current balance, purchase supplies, and sell supplies as various methods.
        // START HERE!!!!!!!!!

        /*public int updatedBalance()
        {
            int newBalance = (UserInput());

            switch (newBalance)
            {

                // Implement userInput?
                case 1:
                    purchaseSupplies();
                    break;
                case 2:
                    sellSupplies();
                    break;
                case 0:
                    break;
                default:
                    break;

            }
            return newBalance;
        }
        // This method will store the number of supplies the user wishes to sell
        public int sellSupplies()
        {
            // Will possibly need to implement method for cost of goods
            // to display quantityPurchased * costOfGoods = totalSold
            int quantitySold = 0;
            int q = quantitySold;
            int totalSold = 0;

            Console.WriteLine("Enter amount of supplies you wish to sell...");
            q = int.Parse(Console.ReadLine());

            totalSold *= quantitySold;

            return totalSold;

        }
        // This method will store the number of supplies the user wishes to purchase
        public int purchaseSupplies()
        {
            // Will possibly need to implement method for cost of goods
            // to display quantityPurchased * costOfGoods = totalPurchased
            int quantityPurchased = 0;
            int q = quantityPurchased;
            int totalPurchased = 0;

            Console.WriteLine("Enter amount of supplies you wish to purchase...");
            q = int.Parse(Console.ReadLine());

            totalPurchased *= quantityPurchased;

            return totalPurchased;
        }


        // This method will determine whether user balance increases or discreases
        public int userBalance()
        {
            int costOfGoods = 0;

            int quantity = int.Parse(Console.ReadLine());

            int balAdjust = 0;

            if (UserInput()== 1)
            {
                costOfGoods = 200;
            }
            else if (UserInput()== 2)
            {
                costOfGoods = -100;
            }

            balAdjust = costOfGoods * quantity;
            return currentBalance += balAdjust;
        }

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

        }*/
    }       
}

