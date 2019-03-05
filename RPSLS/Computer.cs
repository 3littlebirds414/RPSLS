using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        //member variables (Has A)

        //constructor
        public Computer(string name):base(name)
        {

        }
        //member methods (Can Do)
        public override void ChooseGesture()
        {
            Random random = new Random();
            int rng = random.Next(0, 5);
            UsedGesture = gestures.gesturesList[rng];
            
        }
    }
}
