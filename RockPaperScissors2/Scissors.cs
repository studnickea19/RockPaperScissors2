using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Scissors : Gesture
    {

        public Scissors()
        {
            winItems = new List<string> { "paper", "lizard" };
            loseItems = new List<string> { "rock", "spock" };
            gestureName = "scissors";
        }

    }
}
