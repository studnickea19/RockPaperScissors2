using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Gesture
    {
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        public List<string> winItems;
        public  List<string> loseItems;
        public string gestureName;

        public Gesture()
        {
            
        }

        public List<string> GetList()
        {
            return gestures;
        }

    }
}
