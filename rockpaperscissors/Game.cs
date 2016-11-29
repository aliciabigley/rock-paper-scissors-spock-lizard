using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Game
    {
        public Player playerOne;//empty buckets until filled using instanciate them
        public Player playerTwo;

        public void PlayGame()
        {
            DisplayGameWelcome();
            ChooseNumberOfPlayers();
            PlayAlgorithm();
            //while(playerOne.playerScore < 2 || playerTwo.playerScore < 2)
            //{
            //    CalculateWinner();
            //}
        }

        private void PlayAlgorithm()
        {
           
            // d(playerchoice) =5(number of options) a(playerOne) + b(playerTwo) = % 5(number of options)
        }

        public void  DisplayGameWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("\n\nYou may have played Rock, Paper, Scissors, Lizard, Spock in the past, but here are the rules.");
            Console.WriteLine("\n\nRules: Scissors cuts Paper\n\nPaper covers Rock\n\nRock crushes Lizard\n\nLizard poisons Spock\n\nSpock smashes Scissors\n\nScissors decapitates Lizard\n\nLizard eats Paper\n\nPaper disproves Spock\n\nSpock vaporizes Rock\n\n(and as it always has) Rock crushes Scissors");
            Console.WriteLine("Best 2 out of 3 wins!");
            Console.WriteLine("Press Enter To Contiue.");
            Console.ReadLine();
        }

        public void ChooseNumberOfPlayers()
        {

            Console.WriteLine("How many players? 1 or 2");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
                Console.WriteLine("You vs. the computer.\nGood Luck!");
                
            }

            else if (userInput == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
                Console.WriteLine("You vs. another human mind...exciting! Good Luck!");
            }

            else
            {
                Console.WriteLine("Looks like your pushed the wrong key. Try typing 1 or 2");
                ChooseNumberOfPlayers();
            }

        }
        //public void CalculateWinner()
        //{
        //    playerOne.PlayerChoice();
        //    playerTwo.PlayerChoice();
        //    if(playerOne.chooseOption == "Rock" && playerTwo.chooseOption == "Scissors")
        //    {
        //        Console.WriteLine("Player One wins!");
        //        playerOne.playerScore++;
        //    }
        //    else if(playerOne.playerScore)
        //}
        //public void ChooseRock(string acceptance)
        //{
        //    int numberOfWin = 2;
        //    while(numberOfWin < 2)
        //    if (acceptance == "paper")
        //    {
        //        Console.WriteLine("Paper covers Rock. You Lose, better luck next time.");
        //    }
        //    else if (acceptance == "scissors")
        //    {
        //        Console.WriteLine("Rock crushes Scissors! You win!");
        //    }
        //    else if (acceptance == "lizard")
        //    {
        //        Console.WriteLine("Rock crushes Lizard! You win!");
        //    }
        //    else if (acceptance == "spock")
        //    {
        //        Console.WriteLine("Spock vaperizes Rock. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "rock")
        //    {
        //        Console.WriteLine("Tie");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose from ROCK, PAPER, SCISSORS, LIZARD, SPOCK ");
        //    }
        //}
        //public void ChoosePaper(string acceptance)
        //{
        //    int numberOfWin = 2;
        //    while (numberOfWin < 2)
        //    if (acceptance == "rock")
        //    {
        //        Console.WriteLine("Paper covers Rock! You win!");
        //    }
        //    else if (acceptance == "scissors")
        //    {
        //        Console.WriteLine("Scissors cuts Paper. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "lizard")
        //    {
        //        Console.WriteLine("Lizard eats Paper You lose, better luck next time.");
        //    }
        //    else if (acceptance == "spock")
        //    {
        //        Console.WriteLine("Paper disproves Spock! You win!");
        //    }
        //    else if (acceptance == "paper")
        //    {
        //        Console.WriteLine("Tie");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
        //    }
        //}
        //public void ChooseScissor(string acceptance)
        //{
        //    int numberOfWin = 2;
        //    while (numberOfWin < 2)
        //    if (acceptance == "rock")
        //    {
        //        Console.WriteLine("Rock crushes Scissors. You lose, better luck next time");
        //    }
        //    else if (acceptance == "paper")
        //    {
        //        Console.WriteLine("Scissors cuts Paper! You win!");
        //    }
        //    else if (acceptance == "lizard")
        //    {
        //        Console.WriteLine("Scissors decapitates Lizard! You win!");
        //    }
        //    else if (acceptance == "spock")
        //    {
        //        Console.WriteLine("Spock smashes Scissors. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "scissor")
        //    {
        //        Console.WriteLine("Tie");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
        //    }
        //}
        //public void ChooseLizard(string acceptance)
        //{
        //    int numberOfWin = 2;
        //    while (numberOfWin < 2)
        //    if (acceptance == "rock")
        //    {
        //        Console.WriteLine("Rock crushes Lizard. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "paper")
        //    {
        //        Console.WriteLine("Lizard eats paper! You Win!");
        //    }
        //    else if (acceptance == "scissors")
        //    {
        //        Console.WriteLine("Scissors decapitates Lizard. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "spock")
        //    {
        //        Console.WriteLine("Lizard poisens Spock! You win!");
        //    }
        //    else if (acceptance == "lizard")
        //    {
        //        Console.WriteLine("Tie");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
        //    }
        //}
        //public void ChooseSpock(string acceptance)
        //{
        //    int numberOfWin = 2;
        //    while (numberOfWin < 2)
        //    if (acceptance == "rock")
        //    {
        //        Console.WriteLine("Spock vaperizes Rock! You win!");
        //    }
        //    else if (acceptance == "paper")
        //    {
        //        Console.WriteLine("Paper disproves Spock. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "scissors")
        //    {
        //        Console.WriteLine("Spock smashes Scissors. You Win!");
        //    }
        //    else if (acceptance == "lizard")
        //    {
        //        Console.WriteLine("Lizard poisons Spock. You lose, better luck next time.");
        //    }
        //    else if (acceptance == "spock")
        //    {
        //        Console.WriteLine("Tie");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
        //    }
        }
    }
