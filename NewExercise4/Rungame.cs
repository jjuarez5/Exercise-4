﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    class RunGame
    {
        // This method will intialize a new game.
        public void Run()

        {
            var exitProgram = false;

            do
            {
                Console.Clear();
                WelcomeMenu();
                exitProgram = ActOnSelectedItem(UserInput());

            } while (!exitProgram);
        }
                
        // This method will take user input and determine if it is valid.
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

        // This method determines if user wants to continue to new game or exit.
        private bool ActOnSelectedItem(int selection)
        {
            var exit = false;

            switch (selection)
            {
                case 1:
                    new GameStatus().NewGame();
                    break;
                case 0:
                    exit = true;
                    break;               
            }
            return exit;
        }
           
        // This method only diplays the Welcome Menu
        public void WelcomeMenu()
        {
            Console.WriteLine(" Welcome to Space Explorer 1983!\n");
            Console.WriteLine(" Choose an option :");
            Console.WriteLine(" 1. New Game");
            Console.WriteLine(" 0. Exit \n");
        }

    }
}
