using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Human : Player
    {
            public Human()
            {
            }

        public override string SetName()
        {
            Console.WriteLine("Player, please enter your name");
            playerName = Console.ReadLine().ToString();
            return playerName;
        }

        public override Gesture TakeTurn()
		{
            Console.WriteLine("Please enter your selection: Rock, Paper, Scissors, Lizard, Spock");
            string inputGesture = Console.ReadLine().ToLower();
            playerGesture = GetGesture(inputGesture);
            return playerGesture;
		}

        public override Gesture GetGesture(string inputGesture)
        {
            switch (inputGesture)
            {
                case "rock":
                    playerGesture = new Rock();
                    return playerGesture;
                case "paper":
                    playerGesture = new Paper();
                    return playerGesture;
                case "scissors":
                    playerGesture = new Scissors();
                    return playerGesture;
                case "lizard":
                    playerGesture = new Lizard();
                    return playerGesture;
                case "spock":
                    playerGesture = new Spock();
                    return playerGesture;
                default:
                    Console.WriteLine("Invalid Entry");
                    return TakeTurn();
            }

        }

	}
}







