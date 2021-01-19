using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
            //member variables (each game needs two players and a score for them)

        public Player playerOne;
        public Player playerTwo;
        public int playerOneScore;
        public int playerTwoScore;
        public bool humansOnlyGame;

        //member constructor (each new game needs a two entirely new players and scores set to 0)

        public Game()

            
        {      
            playerOneScore = 0;
            playerTwoScore = 0;
            humansOnlyGame = true;
        }

        //member methods


        public void ChooseGameType()
        {
            // DISPLAY RULES 

            Console.WriteLine("Welcome to RPSLS. Choose an object and battle with another player or the computer. If you want to play against another player type yes otherwise no and you'll face the computer.");
            string result = Console.ReadLine();

            if (Console.ReadLine == bool)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }

            else
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
        }
            
         public void ChooseGesture()  //COMPARE GESTURES AND GIVE A POINT TO THE WINNER
                {
            if   gestures.playerOne == "rock" && gestures.playerTwo == "paper")
            {
                Console.WriteLine(" Paper covers Rock!");
                playerTwoScore++;
            }

            else if (gestures.playerOne == "rock" && gestures.playerTwo == "scissors")
            {
                Console.WriteLine(" Rock crushes Scissors!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "rock" && gestures.playerTwo == "lizard")
            {
                Console.WriteLine(" Rock crushes Lizard!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "rock" && gestures.playerTwo == "spock")
            {
                Console.WriteLine(" Spock vaporizes rock!");
                playerTwoScore++;
            }

            else if (gestures.playerOne == "paper" && gestures.playerTwo == "scissors")
            {
                Console.WriteLine("Scissors cuts Paper!");
                playerTwoScore++;
            }

            else if (gestures.playerOne == "paper" && gestures.playerTwo == "rock")
            {
                Console.WriteLine("Paper covers Rock!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "paper" && gestures.playerTwo == "lizard")
            {
                Console.WriteLine("Paper covers Lizard!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "paper" && gestures.playerTwo == "spock")
            {
                Console.WriteLine("Paper disproves Spock!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "scissors" && gestures.playerTwo == "rock")
            {
                Console.WriteLine("Rock crushes Scissors!");
                playerTwoScore++;
            }

            else if (gestures.playerOne == "scissors" && gestures.playerTwo == "paper")
            {
                Console.WriteLine("Scissors cuts Paper!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "scissors" && gestures.playerTwo == "lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "scissors" && gestures.playerTwo == "spock")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                playerOneScore++;
            }

            else if (gestures.playerOne == "lizard" && gestures.playerTwo == "rock")
            {
                Console.WriteLine("Rock crushes Lizard!");
                playerTwoScore++;
            }

            else if (gestures.playerOne == "lizard" && gestures.playerTwo == "paper")
            {
                Console.WriteLine("Lizard eats paper!");
                playerOneScore++;
            }


            else if (gestures.playerOne == "lizard" && gestures.playerTwo == "scissors")
            {
                Console.WriteLine("Lizard eats paper!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "lizard" && gestures.playerTwo == "spock")
            {
                Console.WriteLine("Lizard eats paper!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "spock" && gestures.playerTwo == "rock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "spock" && gestures.playerTwo == "paper")
            {
                Console.WriteLine("Paper disproves Spock!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "spock" && gestures.playerTwo == "scissors")
            {
                Console.WriteLine("Spock smashes scissors!");
                playerOneScore++;
            }

            else if (gestures.playerOne == "spock" && gestures.playerTwo == "lizard")
            {
                Console.WriteLine("Lizard poisons Spock!");
                playerOneScore++;
            }


            else if (gestures.playerOne == "rock" && gestures.playerTwo == "rock")

            {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
            }

            else if (gestures.playerOne == "paper" && gestures.playerTwo == "paper")
            {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
            }

            else if (gestures.playerOne == "scissors" && gestures.playerTwo == "scissors")
            {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
            }

            else if (gestures.playerOne == "lizard" && gestures.playerTwo == "lizard")
            {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
            }

            else if (gestures.playerOne == "spock" && gestures.playerTwo == "spock")
            {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
            }
           
        }
    }

    
}

    








    
}
