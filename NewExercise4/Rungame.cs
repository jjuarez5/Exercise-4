using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class RunGame
    {
        public void Run()
        {
            var exitProgram = false;

            do
            {
                WelcomeMenu();
                exitProgram = ActOnSelectedItem(UserInput());

            } while (!exitProgram);
        }

        private object UserInput()
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
                catch (FormatException fEx)
                {
                    Console.WriteLine("Invalid selection, Space Ranger! Try again!");
                }
            } while (!input);

            return selection;
         
        }

        private bool ActOnSelectedItem(object v)
        {
            throw new NotImplementedException();
            // This is going to be the method that calls method.
            // Implement switch case statement.
        }

        // Method to Display the Welcome menu for the game
        // The Welcome Menu should display
        // -Welcome to Space Explorer 1982!
        // __________________________________
        // Choose an option :
        // 1. New Game
        // 0. Exit
        public void WelcomeMenu()
        {
            Console.WriteLine(" Welcome to Space Explorer 1983!\n");
            Console.WriteLine(" Choose an option :");
            Console.WriteLine(" 1. New Game");
            Console.WriteLine(" 0. Exit \n");
        }
        // try/catch exception handling will go here too
    }
}
