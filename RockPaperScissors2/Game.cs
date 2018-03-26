using System;
namespace RockPaperScissors2
{
    public class Game
    {
        public Game()
        {
            //MEMBER VARIABLES (HAS A)

            //CONSTRUCTOR 

            //MEMBER METHODS (CAN DO)

            public void RunGame()
            {
                StartGame();            //Choose single/mulitplayer    
                //GetPlayers()          //get player names                  
                //get player choices
                //check winner
                //repeat, best 2 of three
            }

            string StartGame()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. Please choose 'single' or 'multiplayer.'");
                string gameStatus = Console.ReadLine().ToLower();
                getPlayers(gameStatus);
                return gameStatus;
            }

            void GetPlayers(string gameStatus)
            {
                if (gameStatus == "single")
                {
                    Human player1 = new Human("playerName");
                    Human.setName();
                    Computer player2 = new Computer("playerName");
                    Computer.setName();
                }
                else if (gameStatus == "multiplayer")
                {
                    Human player1 = new Human("playerName");
                    Human.setName();
                    Human player2 = new Human("playerName");
                    Human.setName();
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter 'single' or 'multiplayer'.");
                }
            }
        }
    }
}
