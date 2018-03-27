using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Scissors : Gesture
    {
        //MEMBER VARIABLES (HAS A)
        List<string> winItems = new List<string> { "paper", "lizard" };
        List<string> loseItems = new List<string> { "rock", "spock" };
        public string gestureName = "scissors";

        //CONSTRUCTOR
        public Scissors()
        {
        }

        //MEMBER METHODS (CAN DO)
    }
}
