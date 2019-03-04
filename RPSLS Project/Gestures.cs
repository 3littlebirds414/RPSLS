using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Gestures
    {
        //member variables (has a...)
        public List<string> gesturesList = new List<string>();
        int win = 0;
        int lose = 0;
        int tie = 0;


        //constructor
        public Gestures()
        {
            gesturesList.Add("Rock");
            gesturesList.Add("Paper");
            gesturesList.Add("Scissors");
            gesturesList.Add("Lizard");
            gesturesList.Add("Spock");
        }


        //member methods (can do...)
        public void Thing()
        {

        }


    }
}
