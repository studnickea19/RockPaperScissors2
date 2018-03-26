using System;
namespace RockPaperScissors2
{
    public class Player
    {
        public Player()
        {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore;
        
            //CONSTRUCTOR (CREATE INSTANCE)

            public Player(string playerName, int playerScore)
            {
                this.playerName = playerName;
                this.playerScore = 0;
            }

            //MEMBER METHODS (CAN DO)

            public void SetName();

            public string TakeTurn();
        }
    }
}
