using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (each game has a...)
        public Player playerOne;
        public Player playerTwo;
        public Player playerThree;
        public int playerOneScore;
        public int playerTwoScore;
        //
        
        //member constructor
        public Game ()
        {
           playerOne = new Human();
           playerTwo = new Human();
           playerThree = new Computer();
           playerOneScore = 0;
           playerTwoScore = 0;
           
        }

        //member methods

        public void StartGame()
        {
           // DISPLAY RULES AND DETERMINE GAME TYPE

            Console.WriteLine("Welcome to RPSLS. You will choose an object and battle with another player or the computer. Do you want to play against another player? Type yes, otherwise no will pit you against the computer.");
            string input = Console.ReadLine();
            if (input = "yes")
            {
                playerOne = new Human;
                playerTwo = new Human;
            }
            else if (input = "no")
            {
                playerOne = new Human;
                playerThree = new Computer;
            }

            // PLAYER ONE CHOOSES INPUT
                 ChooseGesture();

            // PLAYER TWO CHOOSES INPUT
                ChooseGesture();


            //COMPARE GESTURES AND GIVE A POINT TO THE WINNER
            if (  == rock &&  == scissors)
            {
                Console.WriteLine(" Rock crushes Scissors!");
                playerOneScore++;
            }

            else if ( == Rock &&  == Scissors)
            {
                Console.WriteLine(" Rock crushes Scissors!");
                playerOneScore++;
            }

            else if ( == Scissors &&  == Paper)
            {
                Console.WriteLine("Scissors cuts Paper!");
                playerOneScore++;
            }
            
            else if ( == Paper &&  == Rock)
            {
                Console.WriteLine("Paper covers Rock!");
                playerOneScore++;
            }

            else if ( == Rock && == Lizard)
            {
                Console.WriteLine("Rock covers Lizard!");
                playerOneScore++;
            }

            else if (  == Lizard &&  == Spock)
            {
                Console.WriteLine("Lizard poisons Spock!");
                playerOneScore++;
            }

            else if ( == Spock &&  == Scissors)
            {
                Console.WriteLine(("Spock smashes Scissors!");
                playerOneScore++;
            }

            else if ( == Spock &&  == Scissors)
            {    
                Console.WriteLine ("Spock smashes Scissors!");
                playerOneScore++;
            }

            else if ( == Scissors &&  == Lizard)
                Console.WriteLine ("Scissors decapitates Lizard");
                playerOneScore++;

             else if (  == Lizard &&  input  == Paper)
             {
                 Console.WriteLine ("Paper disproves Spock"); 
                 playerOneScore++;
             }

            else if ( == Spock &&  == Rock)
            {
                  Console.WriteLine ("Spock vaporizes Rock!");
                  playerOneScore++;
            }

            else if (  == Rock && == Rock)
                {
                    Console.WriteLine("You chose the same item as the other player. Pick again!");
                }

            else if (== Paper && == Paper)
                {
                Console.WriteLine("You chose the same item as the other player. Pick again!)";
                }
                   
            else if (input player x == Scissors && input player y == Scissors)
                {
                    Console.WriteLine("You chose the same item as the other player. Pick again!");
            }
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
