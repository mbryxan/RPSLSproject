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

                //Two player game

       

       

                 //single player
                 
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
        
      //      else if (input = "no")
       //     {
        //        playerOne = new Human;
       //         playerThree = new Computer;
        //    }

        //    /
        //        ChooseGesture();

        //    /
       //         ChooseGesture();


            //COMPARE GESTURES AND GIVE A POINT TO THE WINNER
            if (  == "rock" &&  gestures.playerTwo == "scissors")
            {
                Console.WriteLine(" Rock crushes Scissors!");
                playerOneScore++;
            }

            else if (playerOne  == rock && playerTwo == Scissors)
            {
                Console.WriteLine(" Rock crushes Scissors!");
                playerOneScore++;
            }

            else if (playerOne == Scissors && playerTwo == Paper)
            {
                Console.WriteLine("Scissors cuts Paper!");
                playerOneScore++;
            }
            
            else if (playerOne  == Paper && playerTwo == Rock)
            {
                Console.WriteLine("Paper covers Rock!");
                playerOneScore++;
            }

            else if (playerOne == Rock && playerTwo == Lizard)
            {
                Console.WriteLine("Rock covers Lizard!");
                playerOneScore++;
            }

            else if (playerOne == Lizard && playerTwo == Spock)
            {
                Console.WriteLine("Lizard poisons Spock!");
                playerOneScore++;
            }

            else if (playerOne == Spock && playerTwo == Scissors)
            {
                Console.WriteLine(("Spock smashes Scissors!");
                playerOneScore++;
            }

            else if (playerOne == Spock && playerTwo == Scissors)
            {    
                Console.WriteLine ("Spock smashes Scissors!");
                playerOneScore++;
            }

            else if (playerOne == Scissors && playerTwo == Lizard)
                Console.WriteLine ("Scissors decapitates Lizard");
                playerOneScore++;

             else if (playerOne == Lizard && playerTwo input  == Paper)
             {
                 Console.WriteLine ("Paper disproves Spock"); 
                 playerOneScore++;
             }

            else if (playerOne == Spock && playerTwo == Rock)
            {
                  Console.WriteLine ("Spock vaporizes Rock!");
                  playerOneScore++;
            }

            else if (playerOne == Rock && == playerTwo Rock)
                {
                    Console.WriteLine("You chose the same item as the other player. Pick again!");
                }

            else if (playerOne == Paper && == playerTwo Paper)
                {
                Console.WriteLine("You chose the same item as the other player. Pick again!)";
                }
                   
            else if (playerOne == Scissors && playerTwo == Scissors)
                {
                    Console.WriteLine("You chose the same item as the other player. Pick again!");
            }
          
            else if (playerOne == Lizard && playerTwo == Lizard)
                {
                Console.WriteLine("You chose the same item as the other player. Pick again!");
                }
             else if (playerOne == Spock && playerTwo == Spock)
                Console.WriteLine("You chose the same item as the other player. Pick again!");
           
        }
    }

    //WHEN ONE PLAYER GETS TO 2 THE GAME IS OVER             


    //   else if (playerTwoInput == C)
    //  {
    //      Console.WriteLine("The battle will begin, you will play against another person.");
    //  }


    //  Logic based on choice of Weapon from List

    //  Generate Round one of Battle
    //
    //      if 
    //      input player x == Rock && input player y == Scissors          
    //      Console.WriteLine (" Rock crushes Scissors!").
    //      player x score = score++ ???

    //  else if
    //      if input player x == Scissors && input player y == Paper           
    //      Console.WriteLine ("Scissors cuts Paper!")
    //    player x score = score++

    //  else if 
    //      input player x == Paper &&  input player y== Rock           
    //      Console.WriteLine ("Paper covers Rock!")              
    //      player x score = score++

    //  else if
    //      input player x == Rock &&  input player y = Lizard
    //      Console.WriteLine ("Rock crushes//     
    //      player x score = score++

    // else if
    //      input player x == Lizard && input player y == Spock
    //      Console.WriteLine ("Lizard poisons Spock");
    //      player x score = score++

    // else if 
    //      input player x == Spock && input player y == Scissors
    //      Console.WriteLine ("Spock smashes Scissors!");
    //      player x score = score++

    // else if 
    //      input player x == Scissors && input player y == Lizard
    //      Console.WriteLine ("Scissors decapitates Lizard");
    //      player x score = score++

    // else if
    //      input player x == Lizard && input player y == Paper
    //      Console.WriteeLine ("Paper disproves Spock");
    //      player x score = score++

    //else if 
    //      input player x == Spock && input player y == Rock
    //      Console.WriteLine (Spock vaporizes Rock!)";
    //      player x score = score++


    //else if 

    //      input player x == Rock && input player y == Rock
    //      Console.WriteLine ("You chose the same item as the other player. Pick again!"

    //else if 

    //      input player x == Paper && input player y == Paper
    //      Console.WriteLine ("You chose the same item as the other player. Pick again!"

    //else if 

    //      input player x == Scissors && input player y == Scissors
    //      Console.WriteLine ("You chose the same item as the other player. Pick again!"


    //else if 

    //      input player x == Lizard && input player y == Lizard
    //      Console.WriteLine ("You chose the same item as the other player. Pick again!"

    //else if 

    //      input player x == Spock && input player y == Spock
    //      Console.WriteLine ("You chose the same item as the other player. Pick again!"
}

    }








    
}
