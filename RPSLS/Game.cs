﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
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

        public void RunGame()
        {
            GameRules();
            CreatePlayers();
            //GameTimes();

            do
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            while (player1.playerScore != 2 && player2.playerScore != 2);

            if (player1.playerScore > player2.playerScore)
            {
                Console.WriteLine(player1.name + " is the big winner!");
            }
            else
            {
                Console.WriteLine(player2.name + " is the big winner!");
            }


            //WhoWon();Nevin

        }
        public void GameRules()
        {
            Console.WriteLine(" 'Here are your rules: Scissors cuts paper, paper covers rock, " +
                "rock crushes lizard, lizard poisons Spock, Spock smashes scissors, " +
                "scissors decapitate lizard, lizard eats paper, paper disproves Spock, Spock vaporizes rock. " +
                "And as it always has, rock crushes scissors.' -- Dr. Sheldon Cooper");
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
        }

        //public void GameTimes()
        //{
        //    Console.WriteLine("How many times do you wish to play?");
        //    GameTimeMax = (Int32.Parse(Console.ReadLine()));
        //}

        public void CompareGestures()
        {
            if (player1.UsedGesture == "Rock")

            {
                Console.WriteLine("Player One chooses Rock");

                if (player2.UsedGesture == "Paper")
                {
                    Console.WriteLine("Player Two Chooses Paper");
                    player2.playerScore++;
                    Console.WriteLine("Player Two - You wrapped it up!  Lol!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    Console.WriteLine("Player Two chooses Scissors");
                    player1.playerScore++;
                    Console.WriteLine("Player One - You smashed it!");

                }
                else if (player2.UsedGesture == "Lizard")
                {
                    Console.WriteLine("Player Two chooses Lizard");
                    player1.playerScore++;
                    Console.WriteLine("Player One - You smashed it!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    Console.WriteLine("Player Two chooses Spock");
                    player2.playerScore++;
                    Console.WriteLine("Player Two - Live long and prosper!  With your rock vaporizer");
                }
                else if (player2.UsedGesture == "Rock")
                {
                    Console.WriteLine("Player Two chooses Rock - its a tie");
                }
            }
            else if (player1.UsedGesture == "Paper")
            {
                Console.WriteLine("Player One chooses Paper");

                if (player2.UsedGesture == "Rock")
                {
                    Console.WriteLine("Player Two chooses Rock");
                    player1.playerScore++;
                    Console.WriteLine("Player One...You wrapped it up!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    Console.WriteLine("Player Two chooses paper...its a tie");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    Console.WriteLine("Player Two chooses Scissors");
                    player2.playerScore++;
                    Console.WriteLine("Player Two...You cut the competition!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    Console.WriteLine("Player Two chooses Lizard");
                    player2.playerScore++;
                    Console.WriteLine("Player Two...You ate the paper!  Good job!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    Console.WriteLine("Player Two chooses Spock");
                    player1.playerScore++;
                    Console.WriteLine("Player One...You disproved Spock...if he could feel stuff, he'd be dissatisfied.");
                }
            }
            else if (player1.UsedGesture == "Scissors")
            {
                Console.WriteLine("Player One chooses Sissors.");

                if (player2.UsedGesture == "Rock")
                {
                    Console.WriteLine("Player Two chooses Rock");
                    player2.playerScore++;
                    Console.WriteLine("Player Two...you smached it!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    Console.WriteLine("Player Two chooses Paper");
                    player1.playerScore++;
                    Console.WriteLine("Player One..you cut the competition!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    Console.WriteLine("Player Two chooses Scissors...its a tie");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    Console.WriteLine("Player Two chooses Lizard");
                    player1.playerScore++;
                    Console.WriteLine("Player One...You cut his head off!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    Console.WriteLine("Player Two chooses Spock");
                    player1.playerScore++;
                    Console.WriteLine("Player Two...Spock has just smashed the scissors.  Just...wow.");
                }
            }
            else if (player1.UsedGesture == "Lizard")
            {
                Console.WriteLine("Player One chooses Lizard");

                if (player2.UsedGesture == "Rock")
                {
                    Console.WriteLine("Player Two chooses Rock");
                    player2.playerScore++;
                    Console.WriteLine("Player Two...you crushed it!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    Console.WriteLine("Player Two chooses Paper");
                    player1.playerScore++;
                    Console.WriteLine("Player One..you ate the competition!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    Console.WriteLine("Player Two chooses Scissors");
                    player2.playerScore++;
                    Console.WriteLine("Player Two...look what you did to the lizzard!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    Console.WriteLine("Player Two chooses Lizard...its a tie");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    Console.WriteLine("Player Two chooses Spock");
                    player1.playerScore++;
                    Console.WriteLine("Player One...you just poisoned Spock.");
                }
            }

            else if (player1.UsedGesture == "Spock")
            {
                Console.WriteLine("Player One chooses Spock");

                if (player2.UsedGesture == "Rock")
                {
                    Console.WriteLine("Player Two chooses Rock");
                    player1.playerScore++;
                    Console.WriteLine("Player One...you vaporized the competion!");
                }
                else if (player2.UsedGesture == "Paper")
                {
                    Console.WriteLine("Player Two chooses Paper");
                    player2.playerScore++;
                    Console.WriteLine("Player Two..you just disproved Spock...well done!");
                }
                else if (player2.UsedGesture == "Scissors")
                {
                    Console.WriteLine("Player Two chooses Scissors");
                    player1.playerScore++;
                    Console.WriteLine("Player One...you smashed the competition!");
                }
                else if (player2.UsedGesture == "Lizard")
                {
                    Console.WriteLine("Player Two chooses Lizard");
                    player2.playerScore++;
                    Console.WriteLine("Player Two... lizards got an agenda!");
                }
                else if (player2.UsedGesture == "Spock")
                {
                    Console.WriteLine("Player Two chooses Spock...its a tie");
                }
            }

        }

    }
}
