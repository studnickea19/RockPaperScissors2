using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Gesture
    {
        List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        List<string> winItems;
        List<string> loseItems;


        public List<string> GetList()
        {
            return gestures;
        }

        public void DetermineScore(Player player1, Player player2, string choice2)
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
