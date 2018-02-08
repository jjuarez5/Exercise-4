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
            int moneyUsed=0;

            if ( moneySpent > this.accountBalance)
            {
                Console.WriteLine("Your current account balance will not support this transaction.\n");
                Console.WriteLine("Do you want to spend all of your credits?\n");
                Console.Write("Enter 'Y' to continue or enter to cancel.\n");
                char yesNo = char.Parse(Console.ReadLine());
                yesNo = char.ToUpper(yesNo);

                if (yesNo == 'Y')
                {
                    moneyUsed = this.accountBalance;
                    this.accountBalance = 0;
                }             
            }
            else
            {
               moneyUsed = moneySpent;
                this.accountBalance -= moneySpent;
            }
            return moneyUsed;
        }        
    }       
}

