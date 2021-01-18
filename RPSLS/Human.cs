using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //member variables

        //public Human human;


        //member constructor

        public Human()

        {

        }


        //member methods
        //Take Turn

        public override Gesture ChooseGesture()
        {
            // First, I need to get input from the user
            // Then, I need to turn that string into an int
            // Then, I need to return a Gesture object from my gestures list using the supplied choice
            // Use the index-1 to access the correct spot

            Console.WriteLine("Please choose your weapon of choice: 1- Rock, 2-Paper 3-Scissors 4-Lizard 5-Spock");
            string input = Console.ReadLine();
            int gesture = int.Parse(input);
            return gestures[gesture-1];

        }









    }
}
