using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Game

    {
        //MEMBER VARIABLES (HAS A)
        Player player1;
        Player player2;

            

        //CONSTRUCTOR
        public Game()
        {
        }

        //MEMBER METHODS (CAN DO)

        //    StartGame();            //Choose single/mulitplayer    
        //    //GetPlayers()          //get player names                  
        //    //get player choices
        //    //check winner
        //    //repeat, best 2 of three

        public string StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. Please choose 'single' or 'multiplayer.'");
            string gameStatus = Console.ReadLine().ToLower();
            GetPlayers(gameStatus);
            return gameStatus;
        }

        void GetPlayers(string gameStatus)
        {
            if (gameStatus == "single")
            {
                player1 = new Human();
                player1.SetName();
                player2 = new Computer();
                player2.SetName();
            }
            else if (gameStatus == "multiplayer")
            {
                player1 = new Human();
                player1.SetName();
                player2 = new Human();
                player2.SetName();
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter 'single' or 'multiplayer'.");
            }


        }
    }
}
