using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Game
    {
        //member variables
        Player player1;
        Player player2;
        public int GameTimeMax;
        public int GameTime;



        //constructor



        //member methods - Nevin adds below
        public void StartGame()
        {
            RunGame();
        }
        public void RunGame()
        {
            GameRules();
            CreatePlayers();
            GameTimes();

            do
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            while (player1.playerScore < 3 || player2.playerScore < 3);

            //WhoWon();Nevin

        }
        public void GameRules()
        {
            Console.WriteLine( " 'Here are your rules: Scissors cuts paper, paper covers rock, " +
                "rock crushes lizard, lizard poisons Spock, Spock smashes scissors, " +
                "scissors decapitate lizard, lizard eats paper, paper disproves Spock, Spock vaporizes rock. " +
                "And as it always has, rock crushes scissors.' -- Dr. Sheldon Cooper" );
        }
        public void CreatePlayers()
        {
            Console.WriteLine("Will there be just 1 player?  Or two?  Please enter a 1 or a 2.");
            String UserInterface = Console.ReadLine();
            

            if (UserInterface == "1")
            {
                Console.WriteLine("What is your name?");
                player1 = new Human(Console.ReadLine());
                player2 = new Computer("Sheldin");
            }
            else if (UserInterface == "2")
            {
                Console.WriteLine("What is your name Human One? ");
                player1 = new Human(Console.ReadLine());
                Console.WriteLine("What is your name Human Two? ");
                player2 = new Human(Console.ReadLine());

            }
            player1.ChooseGesture();
            player2.ChooseGesture();

            
        }
        public void GameTimes()
        {
            Console.WriteLine("How many times do you wish to play?");
                       
            GameTimeMax = (Int32.Parse(Console.ReadLine()));

        }



        public void CompareGestures()
        {
            if (player1.UsedGesture == "Rock")
            {
                if (player2.UsedGesture == "Paper")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two - You wrapped it up!  Lol!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One - You smashed it!");

                }
                else if (player2.UsedGesture == "Lizard")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One - You smashed it!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two - Live long and prosper!  With your rock vaporizer");
                }
                else if (player2.UsedGesture == "Rock")
                {
                    player1.playerScore++;
                    player2.playerScore++;
                    Console.WriteLine("Youre both Big Winners!");
                }
            }
            else if (player1.UsedGesture == "Paper")
            {

                if (player2.UsedGesture == "Rock")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...You wrapped it up!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    player1.playerScore++;
                    player2.playerScore++;
                    Console.WriteLine("Whos the big winner?  You BOTH are!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two...You cut the competition!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two...You ate the paper!  Good job!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...You disproved Spock...if he could feel stuff, he'd be dissatisfied.");
                }
            }



            else if (player1.UsedGesture == "Scissors")
            {

                if (player2.UsedGesture == "Rock")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two...you smached it!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One..you cut the competition!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    player1.playerScore++;
                    player2.playerScore++;
                    Console.WriteLine("Whos the big winners here?  You both are!  Yeah!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...You cut his head off!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player Two...Spock has just smashed the scissors.  Just...wow.");
                }
            }
            else if (player1.UsedGesture == "Lizzard")
            {

                if (player2.UsedGesture == "Rock")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two...you crushed it!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One..you ate the competition!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two...look what you did to the lizzard!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    player1.playerScore++;
                    player2.playerScore++;
                    Console.WriteLine("Two lizards just won this round");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...you just poisoned Spock.");
                }
            }




            else if (player1.UsedGesture == "Spock")
            {

                if (player2.UsedGesture == "Rock")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...you vaporized the competion!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two..you just disproved Spock...well done!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    player1.playerScore++;
                    Console.WriteLine("Player One...you smashed the competition!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    player2.playerScore++;
                    Console.WriteLine("Player Two... lizards got an agenda!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    player1.playerScore++;
                    player2.playerScore++;

                    Console.WriteLine("You both won bc the only thing better than one Spock is Two Spocks.");
                }
            }

        }
       // if(player1.playerScore = 3|| player2.playerScore = 3)
         //   {
           // if(player1.playerScore > player2.playerscore)
             //   {
                //     Console.WriteLine("Player 1 is the winner!  Nice Job!);
    }
}
