using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Computer : Player
    {
        //MEMBER VARIABLES (HAS A)

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
        public override Gesture TakeTurn()
        {
            Gesture gesture = new Gesture();
            List<string> gestures = gesture.GetList();
            Random rnd = new Random();
            int index = rnd.Next(gestures.Count);
            string inputGesture = ((string)gestures[index]);
            playerGesture = GetGesture(inputGesture);
            return playerGesture;
        }

        public override Gesture GetGesture(string inputGesture)
        {
            switch(inputGesture)
            {
                case "rock":
                    playerGesture = new Rock();
                    return playerGesture;
                case "paper":
                    playerGesture = new Paper();
                    return playerGesture;
                case "scissors":
                    playerGesture = new Scissors();
                    return playerGesture;
                case "lizard":
                    playerGesture = new Lizard();
                    return playerGesture;
                case "spock":
                    playerGesture = new Spock();
                    return playerGesture;
            }
            return playerGesture;
        }
    }
}
