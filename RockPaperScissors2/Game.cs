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
            GetChoices(player1, player2);
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

        public void GetChoices(Player player1, Player player2)
        {
            for (int turn = 0; turn <= 3; turn++)
            {
                if (turn < 3)
                {
                    GetPlayer1Choice(player1);
                    GetPlayer2Choice(player2);
                    DetermineScore(player1, player2);
                }
                else if (turn == 3)
                {
                    FinalScore();
                }
            }
        }

        public Gesture GetPlayer1Choice(Player player1)
        {
            Gesture playerGesture = player1.TakeTurn();
            Console.WriteLine("Player1 Gesture: {0}", player1.playerGesture);
            return player1.playerGesture;
        }

        public Gesture GetPlayer2Choice(Player player2)
        {
            Gesture playerGesture = player2.TakeTurn();
            Console.WriteLine("Player2 Gesture: {0}", player2.playerGesture);
            return player2.playerGesture;
        }

        public void DetermineScore(Player player1, Player player2)
        {
            if (player1.playerGesture.winItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Wins!", player1.playerName);
                player1.playerScore++;
                Console.WriteLine("Player1 Score: {0}",player1.playerScore);
            }
            else if (player1.playerGesture.loseItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Wins!", player2.playerName);
                player2.playerScore++;
                Console.WriteLine("Player2 Score: {0}",player2.playerScore);
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



                    