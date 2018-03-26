using System;
namespace RockPaperScissors2
{
    public class Player
    {
        public Player()
        {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore = 0;
        
            //CONSTRUCTOR (CREATE INSTANCE)

            public Player(string playerName)
            {
                this.playerName = playerName;
            }

            //MEMBER METHODS (CAN DO)

            public void SetName();

            //public string TakeTurn();
        }
    }
}
