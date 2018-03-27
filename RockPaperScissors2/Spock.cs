using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Spock : Gesture
    {
        public Spock()
        {
            winItems = new List<string> { "scissors", "rock" };
            loseItems = new List<string> { "paper", "lizard" };
            gestureName = "spock";
        }

    }
}
