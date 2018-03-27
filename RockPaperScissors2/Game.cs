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
                    DetermineScore();
                }
                else if (turn == 4)
                {
                    FinalScore();
                }
            }
        }

        public Gesture GetPlayer1Choice()
        {
            Gesture playerGesture = player1.TakeTurn();
            return playerGesture;
        }

        public Gesture GetPlayer2Choice()
        {
            Gesture playerGesture = player2.TakeTurn();
            return playerGesture;
        }

        public void DetermineScore()
        {
            if (player1.playerGesture.winItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Wins!", player1.playerName);
                player1.playerScore++;
            }
            else if (player1.playerGesture.loseItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Wins!", player2.playerName);
                player2.playerScore++;
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
        public void FinalScore()
        {
            Console.WriteLine("{0} Score:{1}. {2} Score:{3} ", player1.playerName, player1.playerScore, player2.playerName, player2.playerScore);
        }

    }
}



                    