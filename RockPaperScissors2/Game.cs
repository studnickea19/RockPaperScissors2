using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Game
    {
        //MEMBER VARIABLES (HAS A)
        public Player player1;
        public Player player2;
    

        //CONSTRUCTOR
        public Game()
        {}

        //MEMBER METHODS (CAN DO)

        //    StartGame();            //Choose single/mulitplayer    
        //    //GetPlayers()          //get player names                  
        //    //player.TakeTurn();
        //    //rock.decidewinner     //check winner
        //    //repeat, best 2 of three

        public string StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. Please choose 'single' or 'multiplayer.'");
            string gameStatus = Console.ReadLine().ToLower();
            return gameStatus;
        }

        public void GetPlayers(string gameStatus)
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

        public void GetChoices()
        {
            for (int turn = 1; turn <= 4; turn++)
            {
                if (turn < 4)
                {
                    GetPlayer1Choice();
                    GetPlayer2Choice();
                }
                else if (turn == 4)
                {
                    FinalScore();
                }
            }
        }

        string GetPlayer1Choice()
        {
            string choice1 = player1.TakeTurn();
            return choice1;
        }
         
        string GetPlayer2Choice()
        {
            string choice2 = player2.TakeTurn();
            return choice2;
        }
                
        public void FinalScore()
        {
            Console.WriteLine("{0} Score:{1}. {2} Score:{3} ", player1.playerName, player1.playerScore, player2.playerName, player2.playerScore);
        }

    }
}



                    //switch (choice1)
                    //{
                    //    case "rock":
                    //        Rock rock.DetermineScore(player1, player2, choice2);
                    //        break;
                    //    //case "paper":
                    //    //    paper.DetermineScore(player1, player2, choice2);
                    //    //    break;
                    //    //case "scissors":
                    //    //    scissors.DetermineScore(player1, player2, choice2);
                    //    //    break;
                    //    //case "lizard":
                    //    //    lizard.DetermineScore(player1, player2, choice2);
                    //    //    break;
                    //    //case "spock":
                    //        //spock.DetermineScore(player1, player2, choice2);
                    //        //break;
                    //    default:
                    //        Console.WriteLine("Invalid Entry, please choose Rock, Paper, Scissors, Lizard, or Spock");
                    //        break;
                    //}