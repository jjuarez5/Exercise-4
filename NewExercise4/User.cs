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
    }       
}

