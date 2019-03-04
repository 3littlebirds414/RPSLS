using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Human : Player
    {
        //member variable (has a...)
        //public string Human.name;

        //constructor
        public Human(string name):base(name)
        {
            
        }
        //member methods (can do...)
        //Humans choose own gesture

        public override void ChooseGesture()
        {
            Console.WriteLine("Please choose:  Rock, Paper, Scissors, Lizard, Spock");
            UsedGesture = Console.ReadLine();
 
            
        }
    }
}
