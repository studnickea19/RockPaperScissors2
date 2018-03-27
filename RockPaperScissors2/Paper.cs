using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Paper : Gesture
    {
        //MEMBER VARIABLES (HAS A)


        //CONSTRUCTOR
        public Paper()
        {
            winItems = new List<string> { "rock", "spock" };
            loseItems = new List<string> { "scissors", "lizard" };
            gestureName = "paper";
        }

        //MEMBER METHODS (CAN DO)
    }
}
