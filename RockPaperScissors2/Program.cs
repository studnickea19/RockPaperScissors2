using System;
using System.Collections;
using System.Collections.Generic;

namespace RockPaperScissors2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();

            Computer computer = new Computer();
            computer.TakeTurn();
        }
    }
}
