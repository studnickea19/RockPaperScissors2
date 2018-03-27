using System;
using System.Collections;
using System.Collections.Generic;
namespace RockPaperScissors2
{
    public class Computer : Player
    {
        //MEMBER VARIABLES (HAS A)
        public Gesture gestureName;

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
            string compGesture = ((string)gestures[index]);
            playerGesture = GetGesture(compGesture);
            return playerGesture;
        }
        public Gesture GetGesture(string compGesture)
        {
            switch(compGesture)
            {
                case "rock":
                    playerGesture = new Rock();
                    return playerGesture;
                    break;
                case "paper":
                    playerGesture = new Paper();
                    return playerGesture;
                    break;
                case "scissors":
                    playerGesture = new Scissors();
                    return playerGesture;
                    break;
                case "lizard":
                    playerGesture = new Lizard();
                    return playerGesture;
                    break;
                case "spock":
                    playerGesture = new Spock();
                    return playerGesture;
                    break;
            }
        }
    }
}
