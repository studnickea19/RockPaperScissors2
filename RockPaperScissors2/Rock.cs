using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Rock : Gesture
    {
        //MEMBER VARIABLES (HAS A)
        List<string> winItems = new List<string> { "scissors", "lizard" };
        List<string> loseItems = new List<string> { "paper", "spock" };

        //CONSTRUCTOR
        public Rock()
        {
        }

        //MEMBER METHODS (CAN DO)
        public void DetermineScore(player1, player2, string choice2)
        {
            if (winItems.Contains(choice2))
            {
                Console.WriteLine("{0} Wins!", player1.playerName);
                player1.playerScore++;
            }
            else if (loseItems.Contains(choice2))
            {
                Console.WriteLine("{0} Wins!", player2.playerName);
                player2.playerScore++;
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}
