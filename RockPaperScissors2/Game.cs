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
                    Player player1 = new Player("playerName", 0);
                    Human.setName();
                    Player player2 = new Player("Computer", 0);
                    Computer.setName();
                }
                else if (gameStatus == "multiplayer")
                {
                    Player player1 = new Player("playerName", 0);
                    Human.setName();
                    Player player2 = new Player("playerName", 0);
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
