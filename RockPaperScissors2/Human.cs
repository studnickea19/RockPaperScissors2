using System;
namespace RockPaperScissors2
{
    public class Human : Player
    {
        public Human()
        {
            //MEMBER VARIABLES (HAS A)

            public string playerName;
            public int playerScore = 0;

            //CONSTRUCTOR (CREATE INSTANCE)

            //MEMBER METHODS (CAN DO)

            public string SetName()
            {
                Console.WriteLine("Player, please enter your name");
                string player1name = Console.ReadLine().ToString();
                return player1name;
            };

            //public string TakeTurn()
            //{
                
            //};

        }
    }
}







