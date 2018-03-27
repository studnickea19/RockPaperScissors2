using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Rock : Gesture
    {

        public Rock()
        {
            winItems = new List<string> { "scissors", "lizard" };
            loseItems = new List<string> { "paper", "spock" };
            gestureName = "rock";
        }

    }
}
