using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables
        //the List (item) of gestures inherited from player class
        
        //member constructor
        //the actual gestures used by the player

        //member methods
        public override Gesture ChooseGesture()
        //  I need to have a random number chosen by the computer
        {
            Random rng = new Random();
            _ = rng.Next(1, 5);
            string input = Console.ReadLine();
            int gesture = int.Parse(input);
            return gestures[gesture - 1];
        }
    }
}
