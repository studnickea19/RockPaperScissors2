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
        public string gestureName = "rock";

        //CONSTRUCTOR
        public Rock()
        {
        }

        //MEMBER METHODS (CAN DO)

    }
}
