using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class PlayerOptions
    {
        public void ChooseRock(string acceptance)
        {
            if (acceptance == "paper")
            {
                Console.WriteLine("Paper covers Rock. You Lose, better luck next time.");
            }
            else if (acceptance == "scissors")
            {
                Console.WriteLine("Rock crushes Scissors! You win!");
            }
            else if (acceptance == "lizard")
            {
                Console.WriteLine("Rock crushes Lizard! You win!");
            }
            else if (acceptance == "spock")
            {
                Console.WriteLine("Spock vaperizes Rock. You lose, better luck next time.");
            }
            else if (acceptance == "rock")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Please choose from ROCK, PAPER, SCISSORS, LIZARD, SPOCK ");
            }
        }
        public void ChoosePaper(string acceptance)
        {
            if (acceptance == "rock")
            {
                Console.WriteLine("Paper covers Rock! You win!");
            }
            else if (acceptance == "scissors")
            {
                Console.WriteLine("Scissors cuts Paper. You lose, better luck next time.");
            }
            else if (acceptance == "lizard")
            {
                Console.WriteLine("Lizard eats Paper You lose, better luck next time.");
            }
            else if (acceptance == "spock")
            {
                Console.WriteLine("Paper disproves Spock! You win!");
            }
            else if (acceptance == "paper")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
            }
        }
        public void ChooseScissor(string acceptance)
        {
            if (acceptance == "rock")
            {
                Console.WriteLine("Rock crushes Scissors. You lose, better luck next time");
            }
            else if (acceptance == "paper")
            {
                Console.WriteLine("Scissors cuts Paper! You win!");
            }
            else if (acceptance == "lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard! You win!");
            }
            else if (acceptance == "spock")
            {
                Console.WriteLine("Spock smashes Scissors. You lose, better luck next time.");
            }
            else if (acceptance == "scissor")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
            }
        }
        public void ChooseLizard(string acceptance)
        {
            if (acceptance == "rock")
            {
                Console.WriteLine("Rock crushes Lizard. You lose, better luck next time.");
            }
            else if (acceptance == "paper")
            {
                Console.WriteLine("Lizard eats paper! You Win!");
            }
            else if (acceptance == "scissors")
            {
                Console.WriteLine("Scissors decapitates Lizard. You lose, better luck next time.");
            }
            else if (acceptance == "spock")
            {
                Console.WriteLine("Lizard poisens Spock! You win!");
            }
            else if (acceptance == "lizard")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
            }
        }
        public void ChooseSpock(string acceptance)
        {
            if (acceptance == "rock")
            {
                Console.WriteLine("Spock vaperizes Rock! You win!");
            }
            else if (acceptance == "paper")
            {
                Console.WriteLine("Paper disproves Spock. You lose, better luck next time.");
            }
            else if (acceptance == "scissors")
            {
                Console.WriteLine("Spock smashes Scissors. You Win!");
            }
            else if (acceptance == "lizard")
            {
                Console.WriteLine("Lizard poisons Spock. You lose, better luck next time.");
            }
            else if (acceptance == "spock")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Please choose from ROCK, PAPER, SCISSORs, LIZARD, SPOCK ");
            }
        }

    }

}
