using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Paper : Gesture
    {
        //MEMBER VARIABLES (HAS A)
        List<string> winItems = new List<string> { "rock", "spock" };
        List<string> loseItems = new List<string> { "scissors", "lizard" };

        //CONSTRUCTOR
        public Paper()
        {
        }

        //MEMBER METHODS (CAN DO)
    }
}
