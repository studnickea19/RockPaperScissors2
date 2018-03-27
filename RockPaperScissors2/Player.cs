using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    abstract public class Player
    {
            //MEMBER VARIABLES (HAS A)

        public string playerName;
        public int playerScore = 0;
        public Gesture playerGesture;

        
            //CONSTRUCTOR (CREATE INSTANCE)

            public Player()
            {
            }

            //MEMBER METHODS (CAN DO)

            public abstract string SetName();

            public abstract string TakeTurn();

    }
}
