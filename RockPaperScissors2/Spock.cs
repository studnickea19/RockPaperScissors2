using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Spock : Gesture
    {
        //MEMBER VARIABLES (HAS A)


        //CONSTRUCTOR
        public Spock()
        {
            winItems = new List<string> { "scissors", "rock" };
            loseItems = new List<string> { "paper", "lizard" };
            gestureName = "spock";
        }

        //MEMBER METHODS (CAN DO)
    }
}
