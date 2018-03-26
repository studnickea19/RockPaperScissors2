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
            Gesture gesture = new Gesture();
            List<string> gestures = gesture.GetList();
            Random rnd = new Random();
            int index = rnd.Next(gestures.Count);
            computerChoice = ((string)gestures[index]);
            //TEST Console.WriteLine((string)gestures[index]);
            return computerChoice;
        }
    }
}
