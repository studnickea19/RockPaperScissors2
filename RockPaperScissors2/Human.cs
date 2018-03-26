using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Human : Player
    {
            //MEMBER VARIABLES (HAS A)
            public string playerChoice;


            //CONSTRUCTOR (CREATE INSTANCE)
            public Human()
            {
            }

            //MEMBER METHODS (CAN DO)

            public override string SetName()
            {
                Console.WriteLine("Player, please enter your name");
                playerName = Console.ReadLine().ToString();
                return playerName;
            }

		public override string TakeTurn()
		{
            Console.WriteLine("Please enter your selection: Rock, Paper, Scissors, Lizard, Spock");
            playerChoice = Console.ReadLine().ToLower();
            return playerChoice;
		}

	}
}







