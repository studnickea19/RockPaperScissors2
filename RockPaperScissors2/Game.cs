﻿using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Game
    {
        public Player player1;
        public Player player2;

        public Game()
        { }

        public void SetUpGame()
        {
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
                    string start = FinalScore();
                    PlayAgain(start);
                }
            }
        }

        public Gesture GetPlayer1Choice(Player player1)
        {
            Gesture playerGesture = player1.TakeTurn();
            return player1.playerGesture;
        }

        public Gesture GetPlayer2Choice(Player player2)
        {
            Gesture playerGesture = player2.TakeTurn();
            return player2.playerGesture;
        }

        public void DetermineScore(Player player1, Player player2)
        {
            if (player1.playerGesture.winItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Gesture: {1}", player1.playerName, player1.playerGesture);
                Console.WriteLine("{0} Gesture: {1}", player2.playerName, player2.playerGesture);
                Console.WriteLine("{0} Wins!", player1.playerName);
                player1.playerScore++;
                Console.WriteLine("{0} Score: +1", player1.playerName);
            }
            else if (player1.playerGesture.loseItems.Contains(player2.playerGesture.gestureName))
            {
                Console.WriteLine("{0} Gesture: {1}", player1.playerName, player1.playerGesture);
                Console.WriteLine("{0} Gesture: {1}", player2.playerName, player2.playerGesture);
                Console.WriteLine("{0} Wins!", player2.playerName);
                player2.playerScore++;
                Console.WriteLine("{0} Score: +1", player2.playerName);
            }
            else
            {
                Console.WriteLine("{0} Gesture: {1}", player1.playerName, player1.playerGesture);
                Console.WriteLine("{0} Gesture: {1}", player2.playerName, player2.playerGesture);
                Console.WriteLine("Draw!");
            }

        }
        public string FinalScore()
        {
            Console.WriteLine("{0} Score:{1}. {2} Score:{3} ", player1.playerName, player1.playerScore, player2.playerName, player2.playerScore);
            Console.WriteLine("Enter 'Start' to play again");
            string start = Console.ReadLine().ToLower();
            return start;
        }

        public void PlayAgain(string start)
        {
            if(start == "start")
            {
                SetUpGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }

    }
}



                    