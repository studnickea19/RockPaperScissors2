using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    abstract public class Player
    {
        public string playerName;
        public int playerScore = 0;
        public Gesture playerGesture;

            public Player()
            {
            }

            public abstract string SetName();

            public abstract Gesture TakeTurn();

            public abstract Gesture GetGesture(string inputGesture);

    }
}
