using System;

namespace RPSLS_Project
{
    public abstract class Player
    {
        //member variables (Has a)

        public string name;
        public int playerScore;
        public string UsedGesture;
        public string ChooseGesture1;
        public Gestures gestures;



        //constructor


        public Player(string name)
        {
            gestures = new Gestures();
            playerScore = 0;
            this.name = name;
        }



        //member methods(Can do)

        //this feeds to Human and Computer and asks them to Choose a gesture/or generate a gesture
        public abstract void ChooseGesture();






       
    }
}