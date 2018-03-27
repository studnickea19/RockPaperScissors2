using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Rock : Gesture
    {
        //MEMBER VARIABLES (HAS A)


        //CONSTRUCTOR
        public Rock()
        {
            winItems = new List<string> { "scissors", "lizard" };
            loseItems = new List<string> { "paper", "spock" };
            gestureName = "rock";
        }

        //MEMBER METHODS (CAN DO)

    }
}
