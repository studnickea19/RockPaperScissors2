using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Computer : Player
    {
            //MEMBER VARIABLES (HAS A)
            public string computerChoice;

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
            public override string TakeTurn()
            {
                return computerChoice;
            }
    }
}
