using System;
namespace RockPaperScissors2
{
    public class Computer : Player
    {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore = 0;

            //CONSTRUCTOR (CREATE INSTANCE)
            public Computer()
            {
               
            }

            //MEMBER METHODS (CAN DO)

            public override string SetName()
            {
                playerName = "Computer";
                return playerName;
            }
            //public string TakeTurn()
            //{

            //};
    }
}
