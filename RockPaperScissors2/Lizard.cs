using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Lizard : Gesture
    {
        //MEMBER VARIABLES (HAS A)
        List<string> winItems = new List<string> { "spock", "paper" };
        List<string> loseItems = new List<string> { "scissors", "rock" };

        //CONSTRUCTOR
        public Lizard()
        {
        }

        //MEMBER METHODS (CAN DO)
    }
}
