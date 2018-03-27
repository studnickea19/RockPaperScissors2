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
        { }

        //MEMBER METHODS (CAN DO)
        public void SetUpGame()
        {
            //StartGame();
            string c = StartGame();
            GetPlayers(c);
            string d = GetPlayer1Choice();
            string e = GetPlayer2Choice();
            GetChoices(d, e);
        }

        public string StartGame()
        {
            Console.WriteLine("Please choose 'single' or 'multiplayer.'");
            string gameStatus = Console.ReadLine().ToLower();
            return gameStatus;
        }

        public void GetPlayers(string gameStatus)
        {
            Console.WriteLine(gameStatus);
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
                Console.WriteLine("Invalid entry");
                string c = StartGame();
                GetPlayers(c);
            }
        }

        public void GetChoices(string choice1, string choice2)
        {
            for (int turn = 1; turn <= 4; turn++)
            {
                if (turn < 4)
                {
                    GetPlayer1Choice();
                    GetPlayer2Choice();
                    GetRoundResults(player1, player2, choice1, choice2);
                }
                else if (turn == 4)
                {
                    FinalScore();
                }
            }
        }

        public string GetPlayer1Choice()
        {
            string choice1 = player1.TakeTurn();
            return choice1;
        }

        public string GetPlayer2Choice()
        {
            string choice2 = player2.TakeTurn();
            return choice2;
        }

        public void GetRoundResults(Player player1, Player player2, string choice1, string choice2)
        {
            switch (choice1)
            {
                case "rock":
                    Rock rock = new Rock();
;                   rock.DetermineScore(player1, player2, choice2);
                    break;
                case "paper":
                    Paper paper = new Paper();
                    paper.DetermineScore(player1, player2, choice2);
                    break;
                case "scissors":
                    Scissors scissors = new Scissors();
                    scissors.DetermineScore(player1, player2, choice2);
                    break;
                case "lizard":
                    Lizard lizard = new Lizard();
                    lizard.DetermineScore(player1, player2, choice2);
                    break;
                case "spock":
                    Spock spock = new Spock();
                    spock.DetermineScore(player1, player2, choice2);
                    break;
                default:
                    Console.WriteLine("Invalid Entry, please choose Rock, Paper, Scissors, Lizard, or Spock");
                    break;
            }
        }
                
        public void FinalScore()
        {
            Console.WriteLine("{0} Score:{1}. {2} Score:{3} ", player1.playerName, player1.playerScore, player2.playerName, player2.playerScore);
        }

    }
}



                    