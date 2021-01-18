using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS


{


    public abstract class Player
    {
        //member variables- HAS
        public string name;
        public List<Gesture> gestures;
        

        //member constructor -- construct initial values for the variables list above or value type
        public Player()
        {
            gestures = new List<Gesture>();
            Gesture rock = new Gesture("rock");
            Gesture scissors = new Gesture("scissors");
            Gesture paper = new Gesture("paper");
            Gesture lizard = new Gesture("lizard");
            Gesture spock = new Gesture("spock");

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }

        //member method

        public abstract Gesture ChooseGesture();
       
        
               
                

        

    }
}

