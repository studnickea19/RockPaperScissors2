using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Lizard : Gesture
    {
        //MEMBER VARIABLES (HAS A)


        //CONSTRUCTOR
        public Lizard()
        {
            winItems = new List<string> { "spock", "paper" };
            loseItems = new List<string> { "scissors", "rock" };
            gestureName = "lizard";
        }

        //MEMBER METHODS (CAN DO)
    }
}
