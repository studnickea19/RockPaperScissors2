using System;
namespace RockPaperScissors2
{
    abstract public class Player
    {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore;
        
            //CONSTRUCTOR (CREATE INSTANCE)

            public Player()
            {
            }

            //MEMBER METHODS (CAN DO)

            public abstract string SetName();

            //public string TakeTurn();

    }
}
