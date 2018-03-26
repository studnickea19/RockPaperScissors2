using System;
namespace RockPaperScissors2
{
    public class Human : Player
    {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore = 0;

            //CONSTRUCTOR (CREATE INSTANCE)
            public Human()
            {
            }

            //MEMBER METHODS (CAN DO)

            public override string SetName()
            {
                Console.WriteLine("Player, please enter your name");
                playerName = Console.ReadLine().ToString();
                return playerName;
            }

            //public string TakeTurn()
            //{
                
            //};

    }
}







