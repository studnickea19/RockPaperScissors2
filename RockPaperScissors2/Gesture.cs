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

    }
}
