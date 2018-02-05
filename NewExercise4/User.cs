using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class User
    {
        // User starts with an initial balance of 1000 credits
        int currentBalance = 1000;

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

        }
    }       
}

