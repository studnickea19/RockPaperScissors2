using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Spock : Gesture
    {
        //MEMBER VARIABLES (HAS A)
        List<string> winItems = new List<string> { "scissors", "rock" };
        List<string> loseItems = new List<string> { "paper", "lizard" };
        public string gestureName = "spock";

        //CONSTRUCTOR
        public Spock()
        {
        }

        //MEMBER METHODS (CAN DO)
    }
}
