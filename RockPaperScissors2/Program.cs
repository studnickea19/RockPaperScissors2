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
            string c = game.StartGame();
            game.GetPlayers(c);
            game.GetChoices();

        }
    }
}
